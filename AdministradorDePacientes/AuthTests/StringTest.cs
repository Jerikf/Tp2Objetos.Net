using Common.validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AuthTests
{
    [TestClass]
    public class StringTest
    {
        [TestMethod]
        public void StringValidationTrue()
        {
            // Acepta como buen resultado un string o string y espacio, se delimita a ser un nombre/s o apellido/s
            bool result = "juan carlos".StringValidation();
            bool result2 = "juan".StringValidation();
            Assert.AreEqual(true, result);
            Assert.AreEqual(true, result2);
        }

        [TestMethod]
        public void StringValidationFalseEspacioAlInicio()
        {

            //ESPACIOS
            bool result1 = " erik".StringValidation(); //espacio al inicio de una cadena
            bool result2 = "erik ".StringValidation(); //espacio al final de una cadena

            bool result3 = " Erik Jeanpaul".StringValidation(); //Espacio al inicio de dos cadenas
            bool result4 = "Erik Jeanpaul ".StringValidation(); //Espacio al final de dos cadenas
            bool result5 = "Erik  Jeanpaul".StringValidation(); //Dos espacios al separar los cadenas

            //NÚMEROS
            bool result6 = "1erik".StringValidation(); //Número al inicio de una cadena
            bool result7 = "erik4".StringValidation(); //Número al al final de una cadena
            bool result8 = "er5ik".StringValidation(); //Número al centro de una cadena
            bool result9 = "32Er42ik4".StringValidation(); //Números repartidos entre la cadena

            bool result10 = "7Erik Jeanpaul".StringValidation(); //Número al inicio de dos cadenas
            bool result11 = "Erik Jeanpaul7".StringValidation(); //Número al final de dos cadenas
            bool result12 = "Erik Jean7paul".StringValidation(); //Número en la 2da cadena
            bool result13 = "Er3ik 4Jeanpaul".StringValidation(); //Número en las dos cadenas

            //SÏMBOLOS
            bool result14 = "!Erik".StringValidation(); //Símbolo al inicio en una cadena
            bool result15 = "Erik?".StringValidation(); //Símbolo al final de una cadena
            bool result16 = "Er@ik".StringValidation(); //Símbolo al medio de una cadena

            bool result17 = "!Erik jeanpaul".StringValidation(); //Símbolo al inicio en dos cadenas
            bool result18 = "Erik Jeanpaul#".StringValidation(); //Símbolo al final de dos cadenas
            bool result19 = "Er@ik jea%npaul".StringValidation(); //Símbolo en cada cadena

            Assert.AreEqual(false, result1);
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
            Assert.AreEqual(false, result14);
            Assert.AreEqual(false, result15);
            Assert.AreEqual(false, result16);
            Assert.AreEqual(false, result17);
            Assert.AreEqual(false, result18);
            Assert.AreEqual(false, result19);
        }
    }
}
