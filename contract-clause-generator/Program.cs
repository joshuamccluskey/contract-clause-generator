﻿using System;
using System.IO;

namespace contract_clause_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            string q1;
            string q2;
            string q3;
            string q4;
            string q5;

            Console.WriteLine("Welcome to Clause Generator\n");
            Console.WriteLine("Please answer the following questions\n");
            Console.WriteLine("Once complete your clauses will be generated!\n");
            Console.WriteLine("Is your purchase for supplies below $150K ?");

            // Repeat this logic to for service contracts 
            // Anticipate more edge cases
            // Stretch: Try to make a form application instead of using console
            // Stretch: Read JSON files instead of templates

            q1 = Console.ReadLine();
            q1 = q1.ToUpper();
            while (!(q1.Equals("YES")) || (q1.Equals("Y")) || (q1.Equals("NO")) || (q1.Equals("N")))
            {
                Console.WriteLine("Please answer Yes (y) or No (n)!");
                q1 = Console.ReadLine();
                q1 = q1.ToUpper();
            }

            if (q1.Equals("YES") || q1.Equals("Y"))
            {
                Console.WriteLine("Is your purchase above $35K?");
                q2 = Console.ReadLine();
                q2 = q2.ToUpper();
                while (!(q2.Equals("YES")) || (q2.Equals("Y")) || (q2.Equals("NO")) || (q2.Equals("N")))
                {
                    Console.WriteLine("Please answer Yes (y) or No (n)!");
                    q2 = Console.ReadLine();
                    break;
                };
                if (q2 == "YES" || q2 == "Y")
                {
                    Console.WriteLine("Is your purchase above $3.5K?");
                    q3 = Console.ReadLine();
                    q3 = q3.ToUpper();
                    while (q3 != "YES" || q3 != "Y" || q3 != "NO" || q3 != "N")
                    {
                        Console.WriteLine("Please answer Yes (y) or No (n)!");
                        q3 = Console.ReadLine();
                        break;
                    };
                    if (q3 == "YES" || q3 == "Y")
                    {
                        Console.WriteLine("Thank you! you're clauses will be generated");
                        //using (StreamReader sr = new StreamReader("/Users/joshuamccluskey/Desktop/cazure/clauses/clausesTemplate1.txt"))
                        //{
                        //    while ((ln = sr.ReadLine()) != null)
                        //    {
                        //        Console.WriteLine(ln);
                        //    }
                        //}
                    }
                }
                else
                {
                    Console.WriteLine("Is your purchase below $30K?");
                    q4 = Console.ReadLine();
                    q4 = q4.ToUpper();
                    while (q4 != "YES" || q4 != "Y" || q4 != "NO" || q4 != "N")
                    {
                        Console.WriteLine("Please answer Yes (y) or No (n)!");
                        q4 = Console.ReadLine();
                        break;
                    }
                    if (q4 == "YES" || q4 == "Y")
                    {
                        Console.WriteLine("Is your purchase above $3.5K?");
                        q5 = Console.ReadLine();
                        q5 = q5.ToUpper();
                        while (q5 != "YES" || q5 != "Y" || q5 != "NO" || q5 != "N")
                        {
                            Console.WriteLine("Please answer Yes (y) or No (n)!");
                            q5 = Console.ReadLine();
                            break;
                        }
                        if (q5 == "YES" || q5 == "Y")
                        {
                            Console.WriteLine("Thank you! you're clauses will be generated");
                            //        using (StreamReader sr = new StreamReader("/Users/joshuamccluskey/Desktop/cazure/clauses/clausesTemplate2.txt"))

                            //    while ((ln = sr.ReadLine()) != null)
                            //    {
                            //        Console.WriteLine(ln);
                            //    }
                            //}
                            //                }
                            //               }
                            //            } else
                            //{
                            //    Console.WriteLine("Sorry currently your contract is not supported by contract clause generator")
                            //            }


                            string ln = "";


                        }
                    }
                }
            }
        }
    }
}