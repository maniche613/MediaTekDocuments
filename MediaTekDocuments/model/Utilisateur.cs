using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    public class Utilisateur
    {
        public string Id { get; }
        public string Login { get; }
        public string Password { get; }
        public string IdService { get; }
        public string Type { get; }

        public Utilisateur(string id, string login, string password, string idService, string type)
        {
            this.Id = id;
            this.Login = login;
            this.Password = password;
            this.IdService = idService;
            this.Type = type;
        }
    }
}
