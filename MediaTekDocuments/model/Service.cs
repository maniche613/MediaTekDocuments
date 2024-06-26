﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Service (informations d'utilisateur)
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Récupère ou définit l'id d'un service
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Récupère ou définit le libelle d'un service
        /// </summary>
        public string Libelle { get; set; }

        /// <summary>
        /// Initialisation d'un objet Service
        /// </summary>
        /// <param name="id">Id du service</param>
        /// <param name="libelle">Libelle du service</param>
        public Service(string id, string libelle)
        {
            Id = id;
            Libelle = libelle;
        }
    }
}

