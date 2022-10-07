using Sistemarcas.Application.Interfaces;
using Sistemarcas.Domain.Interfaces.Repositories;
using Sistemarcas.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Application.Services
{
    public class DevExternalService : IDevExternalService
    {
        IDevExternalRepository _devExternalRepository;

        public DevExternalService(IDevExternalRepository devExternalRepository)
        {
            _devExternalRepository = devExternalRepository;
        }

        public async Task<bool> OrganizeEmails()
        {
            var devs = await _devExternalRepository.GetAll(); //busca todos os devs da base principal

            const string domain = "@prosoft.com.br";
            string email;
            int index, lenght;

            try
            {
                foreach (var dev in devs)
                {
                    email = dev.Email;
                    index = email.IndexOf('@');
                    lenght = email.Length;

                    if (index > 0 && email.Substring(index, lenght - index) != domain) //verifica domínio
                    {
                        dev.Email = email.Substring(0, index) + domain;

                        await _devExternalRepository.Update(dev);
                    }

                    if (index == 0) //caso não tenha nada antes do @
                    {
                        dev.Email = (string.IsNullOrEmpty(dev.Login) ? dev.Name : dev.Login) + domain;

                        await _devExternalRepository.Update(dev);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }

            return true;
        }
    }
}
