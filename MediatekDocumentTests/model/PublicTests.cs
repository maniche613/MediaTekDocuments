using MediaTekDocuments.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace MediatekDocumentTests.model
{
    [TestClass()]
    public class PublicTests
    {
        private const string id = "10000";
        private const string libelle = "Enfants";
        private static readonly Public lePublic = new Public(id, libelle);
        [TestMethod()]
        public void PublicTest()
        {
            Assert.AreEqual(id, lePublic.Id, "devrait réussir : id valorisé");
            Assert.AreEqual(libelle, lePublic.Libelle, "devrait réussir : libellé valorisé");
        }
    }
}
