using MediaTekDocuments.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MediatekDocumentTests.model
{
	[TestClass()]
    public class CategorieTests
    {
        private const string id = "DVOO6";
        private const string libelle = "Enfants";
        private static readonly Categorie categorie = new Categorie(id, libelle);
        [TestMethod()]
        public void CategorieTest()
        {
            Assert.AreEqual(id, categorie.Id, "devrait réussir : id valorisé");
            Assert.AreEqual(libelle, categorie.Libelle, "devrait réussir : libellé valorisé");
        }
    }
}
