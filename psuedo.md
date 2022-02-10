# Contract Clause Generator Psuedo Code

## Psuedo

This is the general direction for the clause generator. MVP can be acieved via questions answered on the console.

```Csharp
using System;
using System.IO;

namespace contract_clause_generator
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("Welcome to Clause Generator\n")
            Console.WriteLine("Please answer the following questions\n")
            Console.WriteLine("Once complete your clauses will be generated!\n")
            Console.WriteLine("Is your purchase for supplies below $150K ?")

            string q1 = ToUpper.(Console.Read());


            // Repeat this logic to for service contracts 
            // Anticipate more edge cases
            // Stretch: Try to make a form application instead of using console
            // Stretch: Read JSON files instead of templates

             while (q1 != YES || Y || NO || N) {
                Console.WriteLine("Please answer Yes (y) or No (n)!");
                q1 = Console.ReadLine();
            };

            if ("YES" || "Y") {
              Console.WriteLine("Is your purchase above $35K?");
              string q2 = ToUpper.(Console.Read());
               while (q2 != YES || Y || NO || N) {
                Console.WriteLine("Please answer Yes (y) or No (n)!");
                q2 = Console.ReadLine();
            };
               if("YES" || "Y) {
                 Console.WriteLine("Is your purchase above $3.5K?");
                 string q3 = ToUpper.(Console.Read());
                  while (q3 != YES || Y || NO || N) {
                Console.WriteLine("Please answer Yes (y) or No (n)!");
                q3 = Console.ReadLine();
            };
                  if("YES" || "Y) {
                    Console.WriteLine("Thank you! you're clauses will be generated");
                    using (StreamReader sr = new StreamReader("/Users/joshuamccluskey/Desktop/cazure/clauses/clausesTemplate1.txt"))
            {
                while ((ln = sr.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                }
            }
                  }
               } else{
                Console.WriteLine("Is your purchase below $30K?");
                string q4 = ToUpper.(Console.Read());
                 while (q4 != YES || Y || NO || N) {
                Console.WriteLine("Please answer Yes (y) or No (n)!");
                q4 = Console.ReadLine();
            };
                if("YES" || "Y) {
                  Console.WriteLine("Is your purchase above $3.5K?");
                 string q5 = ToUpper.(Console.Read());
                  while (q5 != YES || Y || NO || N) {
                Console.WriteLine("Please answer Yes (y) or No (n)!");
                q5 = Console.ReadLine();
            };
                 if("YES" || "Y) {
                   Console.WriteLine("Thank you! you're clauses will be generated");
                   using (StreamReader sr = new StreamReader("/Users/joshuamccluskey/Desktop/cazure/clauses/clausesTemplate2.txt"))
            {
                while ((ln = sr.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                }
                 }
                }
               }
            } else {
              Console.WriteLine("Sorry currently your contract is not supported by contract clause generator")
            }


             string ln = "";
            

                      using (StreamWriter sw = new StreamWriter("/Users/joshuamccluskey/Desktop/cazure/clauses/NewClauses.txt"))
            {
                foreach(string height in levels)
                {
                    sw.WriteLine(height);
                }
            }

        }
    }
}


```

Overall, I will look into implementing this logic into a form application instead of using the console.
