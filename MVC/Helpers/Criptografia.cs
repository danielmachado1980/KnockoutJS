using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Helpers
{
    public static class Criptografia
    {
        public static string Executar(string palavra)
        {
            String str = string.Empty;
            int unicode;
            foreach (char c in palavra)
            {
                unicode = c;
                if(unicode < 128)
                    str += (char)(unicode + 128);
                else
                    str += (char)(unicode - 128);
            }
            return str;
        }
    }
}