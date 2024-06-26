﻿using MediaTekDocuments.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace MediatekDocumentTests.model
{
    [TestClass()]
    public class GenreTests
    {
        private const string id = "10000";
        private const string libelle = "Humour";
        private static readonly Genre genre = new Genre(id, libelle);
        [TestMethod()]
        public void GenreTest()
        {
            Assert.AreEqual(id, genre.Id, "devrait réussir : id valorisé");
            Assert.AreEqual(libelle, genre.Libelle, "devrait réussir : libellé valorisé");
        }
    }
}
