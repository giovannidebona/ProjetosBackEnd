using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Application.CQRS.Commands
{
    public class DevResponse
    {
        public string Name { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Avatar { get; set; }
        public string Squad { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Tag { get; set; }
    }
}