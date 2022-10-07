using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Sistemarcas.Domain.Configuration;
using Sistemarcas.Domain.Interfaces.Repositories;
using Sistemarcas.Domain.Models;
using Sistemarcas.Infrastructure.Context;
using Sistemarcas.Models.Tests.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Infrastructure.Data.Repositories
{
    public class DevExternalRepository : IDevExternalRepository
    {
        private readonly string urlApi = "https://61a170e06c3b400017e69d00.mockapi.io/DevTest/Dev/";

        private readonly IDevRepository _devRepository;

        public DevExternalRepository(IDevRepository devRepository)
        {
            _devRepository = devRepository;
        }

        public async Task<IEnumerable<DevExternal>> GetAll()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetStringAsync(urlApi);

                    var result = JsonConvert.DeserializeObject<DevExternal[]>(response);

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public async Task<DevExternal> GetById(int id)
        {
            var dev = new DevExternal();

            try
            {
                using (var client = new HttpClient())
                {
                    string jsonObject = JsonConvert.SerializeObject(dev);
                    var content = new StringContent(jsonObject, Encoding.UTF8, "application/json");

                    var response = await client.GetAsync(urlApi + id.ToString());

                    if (response.IsSuccessStatusCode)
                    {
                        var result = response.Content.ReadAsStringAsync();
                        dev = JsonConvert.DeserializeObject<DevExternal>(result.Result);

                        await SyncDataToDev(dev, CommandTypeTest.Insert);

                        return dev;
                    }

                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public async Task<DevExternal> Add(DevExternal dev)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string jsonObject = JsonConvert.SerializeObject(dev);
                    var content = new StringContent(jsonObject, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync(urlApi, content);

                    if (response.IsSuccessStatusCode)
                    {
                        var result = response.Content.ReadAsStringAsync();
                        dev = JsonConvert.DeserializeObject<DevExternal>(result.Result);

                        await SyncDataToDev(dev, CommandTypeTest.Insert);

                        return dev;
                    }

                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public async Task<DevExternal> Update(DevExternal dev)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string jsonObject = JsonConvert.SerializeObject(dev);
                    var content = new StringContent(jsonObject, Encoding.UTF8, "application/json");

                    var response = await client.PutAsync(urlApi + dev.Id, content);

                    if (response.IsSuccessStatusCode)
                    {
                        var result = response.Content.ReadAsStringAsync();
                        dev = JsonConvert.DeserializeObject<DevExternal>(result.Result);

                        await SyncDataToDev(dev, CommandTypeTest.Update);

                        return dev;
                    }

                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public async Task<bool> Remove(DevExternal dev)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string jsonObject = JsonConvert.SerializeObject(dev);
                    var content = new StringContent(jsonObject, Encoding.UTF8, "application/json");

                    var response = await client.DeleteAsync(urlApi + dev.Id.ToString());

                    if (response.IsSuccessStatusCode)
                    {
                        await SyncDataToDev(dev, CommandTypeTest.Delete);

                        return true;
                    }

                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public async Task<bool> SyncDataToDev(DevExternal devExternal, CommandTypeTest commandType)
        {
            try
            {
                if (commandType == CommandTypeTest.Insert) //add
                {
                    var devLocal = new Dev()
                    {
                        Login = devExternal.Login,
                        Email = devExternal.Email,
                        Avatar = devExternal.Avatar,
                        CreatedAt = DateTime.Now,
                        Name = devExternal.Name,
                        Squad = devExternal.Squad,
                        Tag = devExternal.Tag
                    };

                    await _devRepository.Add(devLocal);

                    return true;
                }

                if (commandType == CommandTypeTest.Update) //update
                {
                    var devLocal = (await _devRepository.GetWithFilter(d => d.Email == devExternal.Email && d.Login == devExternal.Login)).FirstOrDefault();

                    if (devLocal != null)
                    {
                        devLocal.Email = devExternal.Email;
                        devLocal.Name = devExternal.Name;
                        devLocal.Avatar = devExternal.Avatar;
                        devLocal.Login = devExternal.Login;
                        devLocal.Tag = devExternal.Tag;
                        devLocal.Squad = devExternal.Squad;

                        await _devRepository.Update(devLocal);
                    }

                    return true;
                }

                if (commandType == CommandTypeTest.Delete) //delete
                {
                    var devLocal = (await _devRepository.GetWithFilter(d => d.Email == devExternal.Email && d.Login == devExternal.Login)).FirstOrDefault();

                    if (devLocal != null)
                    {
                        await _devRepository.Remove(devLocal);
                    }

                    return true;
                }

                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
