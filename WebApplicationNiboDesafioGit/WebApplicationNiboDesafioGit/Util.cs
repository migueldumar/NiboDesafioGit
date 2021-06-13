using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationNiboDesafioGit
{
    public static class Util
    {

        public static bool PrimeiraLetraMaiuscula(this String str)
        {
            if (String.IsNullOrWhiteSpace(str))
                return false;
            Char ch = str[0];
            return Char.IsUpper(ch);
        }




    }
}
