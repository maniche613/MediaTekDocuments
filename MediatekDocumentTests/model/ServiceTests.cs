﻿using MediaTekDocuments.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace MediatekDocumentTests.model
{
    [TestClass]
    public class ServiceTests
    {
        private const string id = "01";
        private const string libelle = "Administratif";

        private static readonly Service service = new Service(id, libelle);

        [TestMethod()]
        public void ServiceTest()
        {
            Assert.AreEqual(id, service.Id, "devrait réussir : id valorisé");
            Assert.AreEqual(libelle, service.Libelle, "devrait réussir : libellé valorisé");
        }
    }
}
