using MediaTekDocuments.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace MediatekDocumentstests.model
{

	[TestClass]
    public class AbonnementTests
    {
        private const string id = "00001";
        private static DateTime dateCommande = DateTime.Parse("2023-04-03");
        private const string montant = "12";
        private static DateTime dateFinAbonnement = DateTime.Parse("2023-05-03");
        private const string idRevue = "10004";
        private const string titre = "Carré";
        private static readonly Abonnement abonnement = new Abonnement(id, dateCommande, montant, dateFinAbonnement, idRevue, titre);
        

        [TestMethod()]
        public void AbonnementTest()
        {
            Assert.AreEqual(id, abonnement.Id, "devrait réussir : id valorisé");
            Assert.AreEqual(dateCommande, abonnement.DateCommande, "devrait réussir : date de commande valorisée");
            Assert.AreEqual(montant, abonnement.Montant, "devrait réussir : montant valorisé");
            Assert.AreEqual(dateFinAbonnement, abonnement.DateFinAbonnement, "devrait réussir : date de fin d'abonnement valorisée");
            Assert.AreEqual(idRevue, abonnement.IdRevue, "devrait réussir : idRevue valorisé");
            Assert.AreEqual(titre, abonnement.Titre, "devrait réussir : titre valorisé");
        }
    }
}
