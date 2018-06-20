using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace suivA.test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        // Fonction qui test la BddRequest.loginRequest
        public void TestLogin()
        {
            BddRequest testLogin = new BddRequest();
            string resultat = testLogin.loginRequest("j","j");
            Assert.AreEqual("103", resultat);
        }

        [TestMethod]
        // Fonction qui test la BddRequest.getVisiteur
        public void testGetVisiteur()
        {
            BddRequest testDuGetVisiteur = new BddRequest();
            Visiteur resultat = testDuGetVisiteur.getVisiteur("97");
            Assert.AreEqual("Berg", resultat.name);
            Assert.AreEqual("Brian", resultat.surname);
            Assert.AreEqual("97", resultat.id);
            Assert.AreEqual("3", resultat.id_medecin);
            Assert.AreEqual("1", resultat.id_role);
            Assert.AreEqual("Schroediner", resultat.medecin_name);
            Assert.AreEqual("Claud", resultat.medecin_surname);
            Assert.AreEqual("22 Rue du 4 Septembre", resultat.medecin_cabinet);
        }

        [TestMethod]
        // Fonction qui test la BddRequest.GetStatMedecin
        public void testStatsMedecin()
        {
            BddRequest testDuGetMedecin = new BddRequest();
            string resultat = testDuGetMedecin.GetStatMedecin("16", "2018-04-01", "2018-04-30");
            Assert.AreEqual("3", resultat);
        }

        [TestMethod]
        // Fonction qui test la BddRequest.GetStatVisiteur
        public void testStatsVisiteur()
        {
            BddRequest testDesStatsVisiteur = new BddRequest();
            string[] resultat = testDesStatsVisiteur.GetStatVisiteur("","");
            Assert.AreEqual("", resultat);
        }
    }
}
