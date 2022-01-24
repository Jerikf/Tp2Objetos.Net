using Common.validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AuthTests
{
    [TestClass]
    public class DniTest
    {
        [TestMethod]
        public void DniValidationTrue()
        {
            bool result1 = "94178431".DniValidation();
            bool result2 = "94-178-431".DniValidation();
            bool result3 = "94.178.431".DniValidation();

            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
        }

        [TestMethod]
        public void DniValidationFalse()
        {
            //SEPARADO EN 3 POR OTRO SÍMBOLO
            bool result1 = "94@178@431".DniValidation(); //SEPARADO POR UN @
            bool result2 = "94!178!431".DniValidation(); //SEPARADO POR UN !
            bool result3 = "94-178#431".DniValidation(); //SEPARADO POR UN VÁLIDO Y UN INVALIDO
            bool result4 = "94!178.431".DniValidation(); //SEPARADO POR UN INVALIDO Y UN VÁLIDO

            //MEZCLAS
            bool result5 = "Aasdfa".DniValidation(); //CADENA
            bool result6 = "lasdjfl13fa".DniValidation(); //CADEN Y NÚMERO
            bool result7 = "393939399".DniValidation(); // 9 DÍGITOS EN VEZ DE 8
            bool result8 = "2345256".DniValidation(); // 7 DIGITOS EN VEZ DE 8

            Assert.AreEqual(false, result1);
            Assert.AreEqual(false, result2);
            Assert.AreEqual(false, result3);
            Assert.AreEqual(false, result4);
            Assert.AreEqual(false, result5);
            Assert.AreEqual(false, result6);
            Assert.AreEqual(false, result7);
            Assert.AreEqual(false, result8);


        }

    }
}
