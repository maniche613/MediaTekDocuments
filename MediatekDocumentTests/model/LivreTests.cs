using MediaTekDocuments.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace MediatekDocumentTests.model
{
    [TestClass()]
    public class LivreTests
    {
        private const string id = "1";
        private const string titre = "Le petit prince";
        private const string image = "lepetitprince.jpg";
        private const string isbn = "9782070612758";
        private const string auteur = "Antoine de Saint-Exupéry";
        private const string collection = "Folio Junior";
        private const string idGenre = "1";
        private const string genre = "Littérature jeunesse";
        private const string idPublic = "1";
        private const string lePublic = "Enfants";
        private const string idRayon = "1";
        private const string rayon = "Romans";
        private static readonly Livre livre = new Livre(id, titre, image, isbn, auteur, collection, idGenre, genre, idPublic, lePublic, idRayon, rayon);


        [TestMethod()]
        public void LivreTest()
        {
            Assert.AreEqual(id, livre.Id);
            Assert.AreEqual(titre, livre.Titre);
            Assert.AreEqual(image, livre.Image);
            Assert.AreEqual(isbn, livre.Isbn);
            Assert.AreEqual(auteur, livre.Auteur);
            Assert.AreEqual(collection, livre.Collection);
            Assert.AreEqual(idGenre, livre.IdGenre);
            Assert.AreEqual(genre, livre.Genre);
            Assert.AreEqual(idPublic, livre.IdPublic);
            Assert.AreEqual(lePublic, livre.Public);
            Assert.AreEqual(idRayon, livre.IdRayon);
            Assert.AreEqual(rayon, livre.Rayon);
        }
    }
}
