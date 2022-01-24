using Common.validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AuthTests
{
    [TestClass]
    public class AgeTest
    {
        [TestMethod]
        public void AgeValidationTrue()
        {
            //Acepta una cadena numerica entero positivo mayor a 0 y menor a 112

            //BORDES
            bool result1 = "1".AgeValidation(); //BORDE INICIAL
            bool result2 = "111".AgeValidation(); //BORDE FINAL

            //EDAD MEDIA
            bool result3 = "29".AgeValidation();

            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
        }

        [TestMethod]
        public void AgeValidationFalse()
        {
            //NO NUMÉRICO
            bool result = "asdfas".AgeValidation(); //CADENA DE ABECEDARIO
            bool result2 = "!()@#".AgeValidation(); //CADENA DE SÍMBOLOS
            bool result3 = "fla@asdf!a".AgeValidation(); //CADEMA SÍMBOLO Y ABECEDARIO
            bool result4 = " ".AgeValidation(); //VACIO
            bool result5 = "asf ".AgeValidation(); //CADENA Y VACIO AL FINAL
            bool result6 = " asdf".AgeValidation(); //CADENA Y VACIO AL INICIAL
            bool result7 = "asdf fasd".AgeValidation(); //MÁS DE UNA CADENA



            //NUMERICO VÁLIDO Y ALGO
            bool result8 = "a23".AgeValidation(); //LETRA AL INICIO
            bool result9 = "18p".AgeValidation(); //LETRA AL FINAL
            bool result10 = "2 3".AgeValidation(); //NÚMEROS SEPARADOS

            //NÉMERO FUERA DEL RANGO
            bool result11 = "112".AgeValidation(); //BORDE ALTO
            bool result12 = "0".AgeValidation(); //BORDE BAJO
            bool result13 = "238".AgeValidation(); //NÚMERO GRANDE FUERA DEL RANGO

            Assert.AreEqual(false, result);
            Assert.AreEqual(false, result2);
            Assert.AreEqual(false, result3);
            Assert.AreEqual(false, result4);
            Assert.AreEqual(false, result5);
            Assert.AreEqual(false, result6);
            Assert.AreEqual(false, result7);
            Assert.AreEqual(false, result8);
            Assert.AreEqual(false, result9);
            Assert.AreEqual(false, result10);
            Assert.AreEqual(false, result11);
            Assert.AreEqual(false, result12);
            Assert.AreEqual(false, result13);

        }



    }
}
