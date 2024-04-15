using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    public class Abonnement : Commande
    {
        /// <summary>
        /// Récupère ou définit la date de fin de l'abonnement
        /// </summary>
        public DateTime DateFinAbonnement { get; set; }
        /// <summary>
        /// Récupère ou définit l'identifiant de la revue correspondant à l'abonnement
        /// </summary>
        public string IdRevue { get; set; }
        /// <summary>
        /// Récupère ou définit le titre de la revue correspondant à l'abonnement
        /// </summary>
        public string Titre { get; set; }

        public Abonnement(string id, DateTime dateCommande, string montant,
            DateTime dateFinAbonnement, string idRevue, string titre)
            : base(id, dateCommande, montant)
        {
            this.DateFinAbonnement = dateFinAbonnement;
            this.IdRevue = idRevue;
            this.Titre = titre;
        }
    }
}
