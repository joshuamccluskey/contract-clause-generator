using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace contract_clause_generator
{
    class Program
    {

        static void Main(string[] args)
        {
                   
          ContractClauseGenerator();

        }

      public static async Task ClauseJSONParserWriterAsync(string path)
        {
            string fileName = path;
            string jsonString = File.ReadAllText(fileName);
            string clauseFilename;
            string username;
            string email;
            string phone;
            string comments;


         
            
            Console.WriteLine("Please enter your name");
            username = Console.ReadLine();
            Console.WriteLine("Please enter your email");
            email = Console.ReadLine();
            Console.WriteLine("Please enter your phone number");
            phone = Console.ReadLine();
            Console.WriteLine("Please enter any amendments or comments");
            comments = Console.ReadLine();
            Console.WriteLine("Please enter your file name");
            clauseFilename = Console.ReadLine();
            //HttpClient client = new HttpClient();
            //string response = await client.GetStringAsync("https://contract-mock-api-1.herokuapp.com/ClausesAbove");
            List<Clause> clauses = JsonConvert.DeserializeObject<List<Clause>>(jsonString);
            DateTime timeDateNow = DateTime.Now;
            Console.WriteLine("Thank you! 🙏 Your clauses are being generated ✍️⌨️ 📄💾 .....");

            string clauseFileLocaiton = "/Users/joshuamccluskey/Desktop/contract-clause-generator/contract-clause-generator/" + clauseFilename + ".txt";
            using (StreamWriter writer = new StreamWriter(clauseFileLocaiton))
            {
                writer.Write($"Prepared by : {username}\nEmail: {email}\nPhone: {phone}\nDate: {timeDateNow}\n\n");
                foreach (var clause in clauses)
                {

                    writer.Write(clause.Codify + "\n" + clause.Title + "\n" + clause.Body + "\n");

                }
                writer.Write($"\n\n Amendments/Comments: {comments} \n\n (End of Contract Language)");
            }
        }



        public static void ContractClauseGenerator()
        {

            string question1;
            string question2;
            string question3;
            string question4;
            string question5;

            Console.WriteLine("Welcome to Clause Generator\n");
            Console.WriteLine("Please answer the following questions\n");
            Console.WriteLine("Once complete your clauses will be generated!\n");
            Console.WriteLine("Is your purchase for supplies below $150K ?");

            question1 = Console.ReadLine();
            question1 = question1.ToUpper();
            while (!(question1.Equals("YES") || (question1.Equals("Y")) || (question1.Equals("NO")) || (question1.Equals("N"))))
            {
                Console.WriteLine("Please answer Yes (y) or No (n)!");
                question1 = Console.ReadLine();
                question1 = question1.ToUpper();
            }
            if (question1.Equals("NO") || question1.Equals("N"))
                Console.WriteLine("Contract Clause Generator Currently Doesn't Support Contracts Above $150K 😰⚠️‼️");

            if (question1.Equals("YES") || question1.Equals("Y"))
            {
                Console.WriteLine("Is your purchase above $35K?");
                question2 = Console.ReadLine();
                question2 = question2.ToUpper();
                while (!(question2.Equals("YES") || (question2.Equals("Y")) || (question2.Equals("NO")) || (question2.Equals("N"))))
                {
                    Console.WriteLine("Please answer Yes (y) or No (n)!");
                    question2 = Console.ReadLine();
                    break;
                };
                if ((question2.Equals("YES")) || (question2.Equals("Y")))
                {
                    Console.WriteLine("Is your purchase above $3.5K?");
                    question3 = Console.ReadLine();
                    question3 = question3.ToUpper();
                    while (!(question3.Equals("YES") || (question3.Equals("Y")) || (question3.Equals("NO")) || (question3.Equals("N"))))
                    {
                        Console.WriteLine("Please answer Yes (y) or No (n)!");
                        question3 = Console.ReadLine();
                        break;
                    };
                    if ((question3.Equals("YES")) || (question3.Equals("Y")))
                    {
                        //This will generrate the clauses needed for supply contracts that are above $35K
                        string path = "/Users/joshuamccluskey/Desktop/contract-clause-generator/contract-clause-generator/clausesAbove35K.json";
                        ClauseJSONParserWriterAsync(path);
                        Console.WriteLine("Thank you for using Contract Clause Generator!!! Your clauses have been generated!!! 🤗🎊🎉🙌");

                    }
                    else
                    {
                        Console.WriteLine("Please Use Your Government Purchase Card 💳 for this purchase. Thank you for using Contract Clause Generator!!!  🤗🎊🎉🙌 !");
                    }
                }
                else
                {
                    Console.WriteLine("Is your purchase below $30K?");
                    question4 = Console.ReadLine();
                    question4 = question4.ToUpper();
                    while (!(question4.Equals("YES") || (question4.Equals("Y")) || (question4.Equals("NO")) || (question4.Equals("N"))))
                    {
                        Console.WriteLine("Please answer Yes (y) or No (n)!");
                        question4 = Console.ReadLine();
                        break;
                    }
                    if ((question4.Equals("YES")) || (question4.Equals("Y")))
                    {
                        Console.WriteLine("Is your purchase above $3.5K?");
                        question5 = Console.ReadLine();
                        question5 = question5.ToUpper();
                        while (!(question5.Equals("YES") || (question5.Equals("Y")) || (question5.Equals("NO")) || (question5.Equals("N"))))
                        {
                            Console.WriteLine("Please answer Yes (y) or No (n)!");
                            question5 = Console.ReadLine();
                            break;
                        }
                        if ((question5.Equals("YES")) || (question5.Equals("Y")))
                        {
                            //This will generrate the clauses needed for supply contracts that are below $35K
                            string path = "/Users/joshuamccluskey/Desktop/contract-clause-generator/contract-clause-generator/clausesBelow35K.json";
                            ClauseJSONParserWriterAsync(path);
                            Console.WriteLine("Thank you for using Contract Clause Generator!!! Your clauses have been generated!!! 🤗🎊🎉🙌");
                        }
                        else
                        {
                            Console.WriteLine("Please Use Your Government Purchase Card 💳 for this purchase  🤗🎊🎉🙌!");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Please Look Over Your Purachse Details and Requirements Again😰⚠️‼️");
                    }
                }
            }
        }
    }
}