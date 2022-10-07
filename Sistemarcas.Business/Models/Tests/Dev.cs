using System;

namespace Sistemarcas.Domain.Models
{
    public class Dev
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Avatar { get; set; }
        public string Squad { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Tag { get; set; }
    }
}