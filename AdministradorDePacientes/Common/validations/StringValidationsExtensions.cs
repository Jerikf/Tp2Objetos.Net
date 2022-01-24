using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Common.validations
{
    public static class StringValidationsExtensions
    {
        public static bool DniValidation(this string dni)
        {
            Regex regex = new Regex(@"^([0-9]{8}|[0-9]{2}\-[0-9]{3}\-[0-9]{3}|[0-9]{2}\.[0-9]{3}\.[0-9]{3})$");
            return regex.IsMatch(dni);
        }
        public static bool StringValidation(this string cadena)
        {
            Regex regex = new Regex(@"^([a-zA-Z]+)\s?([a-zA-Z]+)$");
            return regex.IsMatch(cadena);
        }
         
        public static bool AgeValidation(this string age)
        {
            Regex regex = new Regex(@"^\d+$");
            return (regex.IsMatch(age) && Int32.Parse(age) > 0 && Int32.Parse(age) < 112);
        }
    }
}
