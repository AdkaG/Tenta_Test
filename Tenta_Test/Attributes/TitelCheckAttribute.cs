using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tenta_Test.Attributes
{
    public class TitelCheckAttribute:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return false;
            var toCheck = value.ToString().ToLower();
            return !toCheck.Contains("gun") &&
                   !toCheck.Contains("knife") &&
                   !toCheck.Contains("fight");
        }

        public override string FormatErrorMessage(string field)
        {
            return "Please don't use this word!";
        }
    }
}