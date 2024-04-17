using MediaTekDocuments.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace MediatekDocumentTests.model
{
    [TestClass()]
    public class EtatTests
    {
        private const string id = "01";
        private const string libelle = "neuf";
        private static readonly Etat etat = new Etat(id, libelle);
        [TestMethod()]
        public void EtatTest()
        {
            Assert.AreEqual(id, etat.Id, "devrait réussir : id valorisé");
            Assert.AreEqual(libelle, etat.Libelle, "devrait réussir : libellé valorisé");
        }
    }
}
