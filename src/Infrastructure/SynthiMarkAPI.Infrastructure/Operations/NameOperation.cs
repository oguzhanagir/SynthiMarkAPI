using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Infrastructure.Operations
{
    public static class NameOperation
    {
        public static string CharacterRegulatory(string name)
        {
            string pattern = @"[!'^+%&/()=?\[\]]";
            string replacement = "";
            Regex regex = new Regex(pattern);

            string result = regex.Replace(name, replacement);

            return result;
        }

    }
}
