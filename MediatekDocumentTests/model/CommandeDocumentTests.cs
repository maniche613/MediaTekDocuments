using MediaTekDocuments.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace MediatekDocumentTests.model
{
    [TestClass()]
    public class CommandeDocumentTests
    {
        private const string id = "1";
        private static DateTime dateCommande = DateTime.Parse("2022-02-16");
        private const string montant = "12";
        private const int nbExemplaire = 2;
        private const string idLivreDvd = "4";
        private const string idSuivi = "00001";
        private const string suivi = "en cours";
        private static readonly CommandeDocument commandedocument = new CommandeDocument(id, dateCommande, montant, nbExemplaire, idLivreDvd, idSuivi, suivi);
        [TestMethod()]
        public void CommandeDocumentTest()
        {
            Assert.AreEqual(id, commandedocument.Id, "devrait réussir : id valorisé");
            Assert.AreEqual(dateCommande, commandedocument.DateCommande, "devrait réussir : dateCommande valorisé");
            Assert.AreEqual(montant, commandedocument.Montant, "devrait réussir : montant valorisé");
            Assert.AreEqual(nbExemplaire, commandedocument.NbExemplaire, "devrait réussir : nbExemplaire valorisé");
            Assert.AreEqual(idLivreDvd, commandedocument.IdLivreDvd, "devrait réussir : idLivreDvd valorisé");
            Assert.AreEqual(idSuivi, commandedocument.IdSuivi, "devrait réussir : idSuivi valorisé");
            Assert.AreEqual(suivi, commandedocument.Suivi, "devrait réussir : suivi valorisé");
        }
    }
}
