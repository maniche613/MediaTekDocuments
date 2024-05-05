﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier CommandeDocument hérite de Commande : contient des propriétés spécifiques aux commandes de documents
    /// </summary>
    public class CommandeDocument : Commande
    {
        /// <summary>
        /// Récupère ou définit le nombre d'exemplaires de la commande de document
        /// </summary>
        public int NbExemplaire { get; set; }
        /// <summary>
        /// Récupère ou définit l'id du livreDvd de la commande de document
        /// </summary>
        public string IdLivreDvd { get; set; }
        /// <summary>
        /// Récupère ou définit l'id de l'étape de suivi de la commande de document
        /// </summary>
        public string IdSuivi { get; set; }
        /// <summary>
        /// Récupère ou définit le libelle de l'étape de suivi de la commande de document
        /// </summary>
        public string Suivi { get; set; }

		/// <summary>
		/// Initialisation d'un nouvel objet CommandeDocument
		/// </summary>
		/// <param name="id">Id de la commande de document</param>
		/// <param name="dateCommande">Date de la commande de document</param>
		/// <param name="montant">Montant de la commande de document</param>
		/// <param name="nbExemplaire">Nombre d'exemplaire de la commande de document</param>
		/// <param name="idLivreDvd">Id du LivreDvd correspondant à la commande de document</param>
		/// <param name="idSuivi">Id de l'étape de suivi correspondant à la commande de document</param>
		/// <param name="suivi">libelle de l'etape de suivi de la commande de document</param>
		public CommandeDocument(string id, DateTime dateCommande, string montant, int nbExemplaire,
            string idLivreDvd, string idSuivi, string suivi)
            : base(id, dateCommande, montant)
        {
            this.NbExemplaire = nbExemplaire;
            this.IdLivreDvd = idLivreDvd;
            this.IdSuivi = idSuivi;
            this.Suivi = suivi;
        }
    }
}
