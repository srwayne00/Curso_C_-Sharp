using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aula_27_Dictionary_or_Map
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "997122334";
            cookies["phone"] = "837373882";  //Esse valor sobrescreve o informado anterior

            Console.WriteLine(cookies["user"]);
            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);  //imprime o valor do email
            }
            else
            {
                Console.WriteLine("There's no 'email' key!");
            }

            Console.WriteLine("Size: " + cookies.Count);
            Console.WriteLine("ALL COOKIES");            
            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value); //imprime o nome e valor
            }
        }
    }
}
