using MediaTekDocuments.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace MediatekDocumentTests.model
{
    [TestClass()]
    public class RayonTests
    {
        private const string id = "11";
        private const string libelle = "Enfants";
        private static readonly Rayon rayon = new Rayon(id, libelle);
        [TestMethod()]
        public void RayonTest()
        {
            Assert.AreEqual(id, rayon.Id, "devrait réussir : id valorisé");
            Assert.AreEqual(libelle, rayon.Libelle, "devrait réussir : libellé valorisé");
        }
    }
}
