using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Utilisateur (informations d'authentification)
    /// </summary>
    public class Utilisateur
    {
        /// <summary>
        /// Récupère l'id l'utilisateur
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// Récupère l'identifiant de connexion l'utilisateur
        /// </summary>
        public string Login { get; }
        /// <summary>
        /// Récupère le mot de passe de l'utilisateur
        /// </summary>
        public string Password { get; }
        /// <summary>
        /// Récupère l'id du Service de l'utilisateur
        /// </summary>
        public string IdService { get; }
        /// <summary>
        /// Récupère le type de l'utilisateur
        /// </summary>
        public string Type { get; }

        /// <summary>
        /// Initialisation d'un objet Utilisateur
        /// </summary>
        /// <param name="id">id de l'utilisateur</param>
        /// <param name="login">Login de l'utilisateur</param>
        /// <param name="password">Mot de passe de l'utilisateur</param>
        /// <param name="idService">Id du service de l'utilisateur</param>
        /// <param name="type">Libelle du type de l'utilisateur</param>
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
