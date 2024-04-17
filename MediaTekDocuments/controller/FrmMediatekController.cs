using System.Collections.Generic;
using MediaTekDocuments.model;
using MediaTekDocuments.dal;
using System;

namespace MediaTekDocuments.controller
{
    /// <summary>
    /// Contrôleur lié à FrmMediatek
    /// </summary>
    public class FrmMediatekController
    {
        /// <summary>
        /// Objet d'accès aux données
        /// </summary>
        private readonly Access access;

        /// <summary>
        /// Récupération de l'instance unique d'accès aux données
        /// </summary>
        public FrmMediatekController()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// getter sur la liste des genres
        /// </summary>
        /// <returns>Liste d'objets Genre</returns>
        public List<Categorie> GetAllGenres()
        {
            return access.GetAllGenres();
        }

        /// <summary>
        /// getter sur la liste des livres
        /// </summary>
        /// <returns>Liste d'objets Livre</returns>
        public List<Livre> GetAllLivres()
        {
            return access.GetAllLivres();
        }

        /// <summary>
        /// getter sur la liste des Dvd
        /// </summary>
        /// <returns>Liste d'objets dvd</returns>
        public List<Dvd> GetAllDvd()
        {
            return access.GetAllDvd();
        }

        /// <summary>
        /// getter sur la liste des revues
        /// </summary>
        /// <returns>Liste d'objets Revue</returns>
        public List<Revue> GetAllRevues()
        {
            return access.GetAllRevues();
        }

        /// <summary>
        /// getter sur les rayons
        /// </summary>
        /// <returns>Liste d'objets Rayon</returns>
        public List<Categorie> GetAllRayons()
        {
            return access.GetAllRayons();
        }

        /// <summary>
        /// getter sur les publics
        /// </summary>
        /// <returns>Liste d'objets Public</returns>
        public List<Categorie> GetAllPublics()
        {
            return access.GetAllPublics();
        }

        /// <summary>
        /// getter sur les utilisateurs
        /// </summary>
        /// <returns>Liste d'objets Utilisateur</returns>
        public List<Utilisateur> GetAllUtilisateurs()
        {
            return access.GetAllUtilisateurs();
        }

        /// <summary>
        /// getter sur les abonnements
        /// </summary>
        /// <returns>Liste d'objets Public</returns>
        public List<Abonnement> GetAbonnementsRevue(string idDocument)
        {
            return access.GetAbonnementsRevue(idDocument);
        }

        /// <summary>
        /// Crée un exemplaire d'une revue dans la bdd
        /// </summary>
        /// <param name="abonnement">L'objet Exemplaire concerné</param>
        /// <returns>True si la création a pu se faire</returns>
        public bool CreerAbonnement(Abonnement abonnement)
        {
            return access.CreerAbonnement(abonnement);
        }

        /// <summary>
        /// Supprimer un abonnement d'une revue dans la bdd
        /// </summary>
        /// <param name="abonnement">L'objet Abonnement concerné</param>
        /// <returns>True si la suppression a pu se faire</returns>
        public bool SuppAbonnement(Abonnement abonnement)
        {
            return access.SuppAbonnement(abonnement);
        }

        /// <summary>
        /// getter sur les abonnements
        /// </summary>
        /// <returns>Liste d'objets Abonnement</returns>
        public List<Abonnement> GetAbonnements()
        {
            return access.GetAbonnements();
        }

        /// <summary>
        /// récupère les exemplaires d'une revue
        /// </summary>
        /// <param name="idDocuement">id de la revue concernée</param>
        /// <returns>Liste d'objets Exemplaire</returns>
        public List<Exemplaire> GetExemplairesRevue(string idDocuement)
        {
            return access.GetExemplairesRevue(idDocuement);
        }

        /// <summary>
        /// Crée un exemplaire d'une revue dans la bdd
        /// </summary>
        /// <param name="exemplaire">L'objet Exemplaire concerné</param>
        /// <returns>True si la création a pu se faire</returns>
        public bool CreerExemplaire(Exemplaire exemplaire)
        {
            return access.CreerExemplaire(exemplaire);
        }

        /// <summary>
        /// récupère les commandes d'un livre
        /// </summary>
        /// <param name="idDocument">id du livre concerné</param>
        /// <returns>Liste d'objets Commandes</returns>
        public List<CommandeDocument> GetCommandes(string idDocument)
        {
            return access.GetCommandes(idDocument);
        }

        /// <summary>
        /// Crée une commande d'un document dans la bdd
        /// </summary>
        /// <param name="commandedocument">L'objet CommandeDocument concerné</param>
        /// <returns>True si la création a pu se faire</returns>
        public bool CreerCommandeDocument(CommandeDocument commandedocument)
        {
            return access.CreerCommandeDocument(commandedocument);
        }

        /// <summary>
        /// Modifie une commande d'un document dans la bdd
        /// </summary>
        /// <param name="commandedocument">L'objet CommandeDocument concerné</param>
        /// <returns>True si la création a pu se faire</returns>
        public bool SetCommandeDocument(CommandeDocument commandedocument)
        {
            return access.SetCommandeDocument(commandedocument);
        }

        /// <summary>
        /// Supprime une commande d'un document dans la bdd
        /// </summary>
        /// <param name="commandedocument">L'objet CommandeDocument concerné</param>
        /// <returns>True si la création a pu se faire</returns>
        public bool SuppComandeDocument(CommandeDocument commandedocument)
        {
            return access.SuppComandeDocument(commandedocument);
        }

        /// <summary>
        /// Vérifie si les date de parution est entre la date de commande et la date de fin d'abonnement
        /// </summary>
        /// <param name="dateCommande">la date de commande concerné</param>
        /// <param name="dateFinAbonnement">la date de fin d'abonnement concernée</param>
        /// <param name="dateParution">la date de parution concerné</param>
        /// <returns></returns>
        public bool ParutionDansAbonnement(DateTime dateCommande, DateTime dateFinAbonnement, DateTime dateParution)
        {
            return (DateTime.Compare(dateCommande, dateParution) < 0 && DateTime.Compare(dateParution, dateFinAbonnement) < 0);
        }
    }
}
