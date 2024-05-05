using System;
using System.Collections.Generic;
using MediaTekDocuments.model;
using MediaTekDocuments.manager;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Configuration;
using Serilog;
using Serilog.Formatting.Json;

namespace MediaTekDocuments.dal
{
    /// <summary>
    /// Classe d'accès aux données
    /// </summary>
    public class Access
    {
        /// <summary>
        /// adresse de l'API
        /// </summary>
#pragma warning disable S1075 // URIs should not be hardcoded
        private static readonly string uriApi = "http://localhost/rest_mediatekdocuments3.0/";
#pragma warning restore S1075 // URIs should not be hardcoded
        /// <summary>
        /// nom de connexion à la bdd
        /// </summary>
        private static readonly string connectionName = "MediaTekDocuments.Properties.Settings.mediatek86ConnectionString";
        /// <summary>
        /// instance unique de la classe
        /// </summary>
        private static Access instance = null;
        /// <summary>
        /// instance de ApiRest pour envoyer des demandes vers l'api et recevoir la réponse
        /// </summary>
        private readonly ApiRest api = null;
        /// <summary>
        /// méthode HTTP pour select
        /// </summary>
        private const string GET = "GET";
        /// <summary>
        /// méthode HTTP pour insert
        /// </summary>
        private const string POST = "POST";
        /// <summary>
        /// méthode HTTP pour update
        ///  </summary>
        private const string PUT = "PUT";
        /// <summary>
        /// méthode HTTP pour delete
        ///  </summary>
        private const string DELETE = "DELETE";
        /// Méthode privée pour créer un singleton
        /// initialise l'accès à l'API

        /// <summary>
        /// Récupération de la chaîne de connexion
        /// </summary>
        /// <param name="name">nom de la chaîne de connexion</param>
        /// <returns></returns>
        static string GetConnectionStringByName(string name)
        {
            string value = null;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
                value = settings.ConnectionString;
            return value;
        }

        /// <summary>
        /// Récupération de l'instance pour accéder à l'API
        /// </summary>
        private Access()
        {
            String authenticationString;
            try
            {
                authenticationString = GetConnectionStringByName(connectionName);
                // authenticationString = "admin:adminpwd";

                Log.Logger = new LoggerConfiguration()
                    .MinimumLevel.Verbose()
                    .WriteTo.Console()
                    .WriteTo.File(new JsonFormatter(), "logs/logs.txt",
                    rollingInterval: RollingInterval.Day)
                    .CreateLogger();

                api = ApiRest.GetInstance(uriApi, authenticationString);
            }
            catch (Exception e)
            {
                Log.Fatal("Access.Access catch connectionString={0} erreur={1}", connectionName, e.Message);
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Création et retour de l'instance unique de la classe
        /// </summary>
        /// <returns>instance unique de la classe</returns>
        public static Access GetInstance()
        {
            if (instance == null)
            {
                instance = new Access();
            }
            return instance;
        }

        /// <summary>
        /// Retourne tous les genres à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Genre</returns>
        public List<Categorie> GetAllGenres()
        {
            IEnumerable<Genre> lesGenres = TraitementRecup<Genre>(GET, "genre");
            return new List<Categorie>(lesGenres);
        }

        /// <summary>
        /// Retourne tous les rayons à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Rayon</returns>
        public List<Categorie> GetAllRayons()
        {
            IEnumerable<Rayon> lesRayons = TraitementRecup<Rayon>(GET, "rayon");
            return new List<Categorie>(lesRayons);
        }

        /// <summary>
        /// Retourne toutes les catégories de public à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Public</returns>
        public List<Categorie> GetAllPublics()
        {
            IEnumerable<Public> lesPublics = TraitementRecup<Public>(GET, "public");
            return new List<Categorie>(lesPublics);
        }

        /// <summary>
        /// Retourne toutes les livres à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Livre</returns>
        public List<Livre> GetAllLivres()
        {
            List<Livre> lesLivres = TraitementRecup<Livre>(GET, "livre");
            return lesLivres;
        }

        /// <summary>
        /// Retourne toutes les dvd à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Dvd</returns>
        public List<Dvd> GetAllDvd()
        {
            List<Dvd> lesDvd = TraitementRecup<Dvd>(GET, "dvd");
            return lesDvd;
        }

        /// <summary>
        /// Retourne tous les utilisateurs à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Utilisateur</returns>
        public List<Utilisateur> GetAllUtilisateurs()
        {
            List<Utilisateur> lesUtilisateurs = TraitementRecup<Utilisateur>(GET, "utilisateur");
            return lesUtilisateurs;
        }

        /// <summary>
        /// Retourne toutes les revues à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Revue</returns>
        public List<Revue> GetAllRevues()
        {
            List<Revue> lesRevues = TraitementRecup<Revue>(GET, "revue");
            return lesRevues;
        }

        /// <summary>
        /// Retourne les abonnements d'une revue
        /// </summary>
        /// <returns>Liste d'objets Abonnement</returns>
        public List<Abonnement> GetAbonnementsRevue(string idDocument)
        {
            List<Abonnement> lesAbonnements = TraitementRecup<Abonnement>(GET, "abonnement/" + idDocument);
            return lesAbonnements;
        }

        /// <summary>
        /// ecriture d'un abonnement en base de données
        /// </summary>
        /// <param name="abonnement">abonnement à insérer</param>
        /// <returns>true si l'insertion a pu se faire (retour != null)</returns>
        public bool CreerAbonnement(Abonnement abonnement)
        {
            String jsonAbonnement = JsonConvert.SerializeObject(abonnement, new CustomDateTimeConverter());
            try
            {
                // récupération soit d'une liste vide (requête ok) soit de null (erreur)
                List<Abonnement> liste = TraitementRecup<Abonnement>(POST, "abonnement/" + jsonAbonnement);
                return (liste != null);
            }
            catch (Exception ex)
            {
                Log.Error("Access.CreerAbonnement catch jsonAbonnement={0} erreur={1}", jsonAbonnement, ex.Message);
            }
            return false;
        }

        /// <summary>
        /// ecriture d'un abonnement en base de données 
        /// </summary>
        /// <param name="abonnement">abonnement à supprimer</param>
        /// <returns>true si l'insertion a pu se faire (retour != null)</returns>
        public bool SuppAbonnement(Abonnement abonnement)
        {
            String jsonAbonnement = JsonConvert.SerializeObject(abonnement, new CustomDateTimeConverter());
            Console.WriteLine("****************" + jsonAbonnement);
            try
            {
                // récupération soit d'une liste vide (requête ok) soit de null (erreur)
                List<Abonnement> liste = TraitementRecup<Abonnement>(DELETE, "abonnement/" + jsonAbonnement);
                return (liste != null);
            }
            catch (Exception ex)
            {
                Log.Error("Access.SuppAbonnement catch jsonAbonnement={0} erreur={1}", jsonAbonnement, ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Retourne tous les abonnements
        /// </summary>
        /// <returns>Liste d'objets Abonnement</returns>
        public List<Abonnement> GetAbonnements()
        {
            List<Abonnement> lesAbonnements = TraitementRecup<Abonnement>(GET, "abonnements");
            return lesAbonnements;
        }

        /// <summary>
        /// Retourne les exemplaires d'une revue
        /// </summary>
        /// <param name="idDocument">id de la revue concernée</param>
        /// <returns>Liste d'objets Exemplaire</returns>
        public List<Exemplaire> GetExemplairesRevue(string idDocument)
        {
            List<Exemplaire> lesExemplaires = TraitementRecup<Exemplaire>(GET, "exemplaire/" + idDocument);
            return lesExemplaires;
        }

        /// <summary>
        /// ecriture d'un exemplaire en base de données
        /// </summary>
        /// <param name="exemplaire">exemplaire à insérer</param>
        /// <returns>true si l'insertion a pu se faire (retour != null)</returns>
        public bool CreerExemplaire(Exemplaire exemplaire)
        {
            String jsonExemplaire = JsonConvert.SerializeObject(exemplaire, new CustomDateTimeConverter());
            try
            {
                // récupération soit d'une liste vide (requête ok) soit de null (erreur)
                List<Exemplaire> liste = TraitementRecup<Exemplaire>(POST, "exemplaire/" + jsonExemplaire);
                return (liste != null);
            }
            catch (Exception ex)
            {
                Log.Error("Access.CreerExemplaire catch jsonExemplaire={0} erreur={1}", jsonExemplaire, ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Retourne les commandes d'un livre
        /// </summary>
        /// <param name="idDocument">id du livre concerné</param>
        /// <returns>Liste d'objets Commandes</returns>
        public List<CommandeDocument> GetCommandes(string idDocument)
        {
            List<CommandeDocument> lesCommandes = TraitementRecup<CommandeDocument>(GET, "commandedocument/" + idDocument);
            return lesCommandes;
        }

        /// <summary>
        /// ecriture d'une commandedocument en base de données
        /// </summary>
        /// <param name="commandedocument">commandedocument à insérer</param>
        /// <returns>true si l'insertion a pu se faire (retour != null)</returns>
        public bool CreerCommandeDocument(CommandeDocument commandedocument)
        {
            String jsonCommandeDocument = JsonConvert.SerializeObject(commandedocument, new CustomDateTimeConverter());
            try
            {
                // récupération soit d'une liste vide (requête ok) soit de null (erreur)
                List<CommandeDocument> liste = TraitementRecup<CommandeDocument>(POST, "commandedocument/" + jsonCommandeDocument);
                return (liste != null);
            }
            catch (Exception ex)
            {
                Log.Error("Access.CreerCommandeDocument catch jsonCommandeDocument={0} erreur={1}", jsonCommandeDocument, ex.Message);
            }
            return false;
        }

        /// <summary>
        /// ecriture d'une commandedocument en base de données
        /// </summary>
        /// <param name="commandedocument">commandedocument à modifier</param>
        /// <returns>true si l'insertion a pu se faire (retour != null)</returns>
        public bool SetCommandeDocument(CommandeDocument commandedocument)
        {
            String jsonCommandeDocument = JsonConvert.SerializeObject(commandedocument, new CustomDateTimeConverter());
            try
            {
                // récupération soit d'une liste vide (requête ok) soit de null (erreur)
                List<Commande> liste = TraitementRecup<Commande>(PUT, "commandedocument/" + commandedocument.Id + "/" + jsonCommandeDocument);
                return (liste != null);
            }
            catch (Exception ex)
            {
                Log.Error("Access.SetCommandeDocument catch jsonCommandeDocument={0} erreur={1}", jsonCommandeDocument, ex.Message);
            }
            return false;
        }

        /// <summary>
        /// ecriture d'une commandedocument en base de données
        /// </summary>
        /// <param name="commandedocument">commandedocument à supprimer</param>
        /// <returns>true si l'insertion a pu se faire (retour != null)</returns>
        public bool SuppComandeDocument(CommandeDocument commandedocument)
        {
            String jsonCommandeDocument = JsonConvert.SerializeObject(commandedocument, new CustomDateTimeConverter());
            try
            {
                // récupération soit d'une liste vide (requête ok) soit de null (erreur)
                List<Commande> liste = TraitementRecup<Commande>(DELETE, "commandedocument/" + jsonCommandeDocument);
                return (liste != null);
            }
            catch (Exception ex)
            {
                Log.Error("Access.SuppCommandeDocument catch jsonCommandeDocument={0} erreur={1}", jsonCommandeDocument, ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Traitement de la récupération du retour de l'api, avec conversion du json en liste pour les select (GET)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="methode">verbe HTTP (GET, POST, PUT, DELETE)</param>
        /// <param name="message">information envoyée</param>
        /// <returns>liste d'objets récupérés (ou liste vide)</returns>
        private List<T> TraitementRecup<T>(String methode, String message)
        {
            List<T> liste = new List<T>();
            try
            {
                JObject retour = api.RecupDistant(methode, message);
                // extraction du code retourné
                String code = (String)retour["code"];
                if (code.Equals("200"))
                {
                    // dans le cas du GET (select), récupération de la liste d'objets
                    if (methode.Equals(GET))
                    {
                        String resultString = JsonConvert.SerializeObject(retour["result"]);
                        // construction de la liste d'objets à partir du retour de l'api
                        liste = JsonConvert.DeserializeObject<List<T>>(resultString, new CustomBooleanJsonConverter());
                    }
                }
                else
                {
                    Log.Error("Access.TraitementRecup catch code={0} erreur={1}", code, (String)retour["message"]);
                }
            }
            catch (Exception e)
            {
                Log.Error("Access.TraitementRecup catch liste={0} erreur={1}", liste, e.Message);
                Environment.Exit(0);
            }
            return liste;
        }

        /// <summary>
        /// Modification du convertisseur Json pour gérer le format de date
        /// </summary>
        private sealed class CustomDateTimeConverter : IsoDateTimeConverter
        {
            public CustomDateTimeConverter()
            {
                base.DateTimeFormat = "yyyy-MM-dd";
            }
        }

        /// <summary>
        /// Modification du convertisseur Json pour prendre en compte les booléens
        /// classe trouvée sur le site :
        /// https://www.thecodebuzz.com/newtonsoft-jsonreaderexception-could-not-convert-string-to-boolean/
        /// </summary>
        private sealed class CustomBooleanJsonConverter : JsonConverter<bool>
        {
            public override bool ReadJson(JsonReader reader, Type objectType, bool existingValue, bool hasExistingValue, JsonSerializer serializer)
            {
                return Convert.ToBoolean(reader.ValueType == typeof(string) ? Convert.ToByte(reader.Value) : reader.Value);
            }

            public override void WriteJson(JsonWriter writer, bool value, JsonSerializer serializer)
            {
                serializer.Serialize(writer, value);
            }
        }

    }
}
