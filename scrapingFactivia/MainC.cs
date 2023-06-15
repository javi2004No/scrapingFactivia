using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace scrapingFactivia
{
    public class MainC
    {
        static void Main(string[] args)
        {
            /*
            List<ExcelOutput.ExcelStructure> excelStructures = new List<ExcelOutput.ExcelStructure>();
            excelStructures.Add(new ExcelOutput.ExcelStructure());
            excelStructures[0].Header = "Temperature";
            excelStructures[0].Data = new List<string>();
            excelStructures[0].Data.Add("2342");
            excelStructures[0].Data.Add("23");
            excelStructures[0].Data.Add("8921");
            excelStructures[0].Data.Add("4231");
            excelStructures.Add(new ExcelOutput.ExcelStructure());
            excelStructures[1].Header = "Locations";
            excelStructures[1].Data = new List<string>();
            excelStructures[1].Data.Add("Miami");
            excelStructures[1].Data.Add("Miramar");
            excelStructures[1].Data.Add("New York");
            excelStructures[1].Data.Add("Chicago");
            ExcelOutput.WriteToExcel write = new ExcelOutput.WriteToExcel();
            write.createExcel(excelStructures, "Local Temperaturest");
            */
            FactaviaAPICall.Authorization authorize = null;
            Console.WriteLine("Factavia to Excel scrapper.");
            Console.WriteLine("Do you allready have an authorization token?");
            string answer = Console.ReadLine();
            string sToken = "";
            if (answer == "n" || answer == "N")
            {
                bool valid = false;
                do
                {
                    Console.WriteLine("What is your username?");
                    string username = Console.ReadLine();
                    Console.WriteLine("What is your password?");
                    string password = Console.ReadLine();
                    if (authorize == null)
                    {
                        Console.WriteLine("What is your client id?");
                        string client_id = Console.ReadLine();
                        authorize = new FactaviaAPICall.Authorization(client_id);
                    }
                    Task<APIResponseStructures.TokenV2> tToken = authorize.getAuthourization(username, password);
                    APIResponseStructures.TokenV2 token = tToken.Result;
                    if (token == null)
                    {
                        Console.WriteLine("Error getting the access token. You may have a wrong password, username, or ID. Type them in again");
                        authorize = null;
                    }
                    else
                    {
                        Console.WriteLine("Success in getting authorization");
                        Console.WriteLine("Token expires in {0} seconds", token.expires_in);
                        Console.WriteLine("Do you want to save the token?");
                        answer = Console.ReadLine();
                        if( answer == "y" || answer == "Y")
                        {
                            Console.WriteLine("Please type where you want to save it.");
                            answer = Console.ReadLine();
                            StreamWriter outputFile = new StreamWriter(answer);
                            outputFile.WriteLine(token.access_token);
                            outputFile.Close();
                        }
                        valid = true;
                        sToken = token.access_token;
                    }
                } while (!valid);
            }
            else
            {
                Console.WriteLine("Type in your authorization token:");
                sToken = Console.ReadLine();
            }
            bool on = true;
            do
            {
                Console.WriteLine("Type what you wish to search:");
                string searchTerm = Console.ReadLine();
                //Remeber to change string
                FactaviaAPICall.APICall aPICall = new FactaviaAPICall.APICall();
                Task<Structures.Root> root = aPICall.Search(searchTerm, sToken);
                Structures.Root root2 = root.Result;
                if(root2 != null)
                {
                    Console.WriteLine("Search is a success");
                    Console.WriteLine("Where do you want to export it to?");
                    answer = Console.ReadLine();
                    Console.WriteLine("What do you want the name of the excel to be?");
                    string name = Console.ReadLine();
                    List<ExcelOutput.ExcelStructure> excelStructures = new List<ExcelOutput.ExcelStructure>();
                    excelStructures.Add(new ExcelOutput.ExcelStructure());
                    excelStructures[0].Header = "PDF links";
                    for(int i = 0; i < root2.data.Count; i++)
                    {
                        excelStructures[0].Data.Add(root2.data[i].links.pdf);
                    }
                    excelStructures.Add(new ExcelOutput.ExcelStructure());
                    excelStructures[1].Header = "Title";
                    for (int i = 0; i < root2.data.Count; i++)
                    {
                        excelStructures[1].Data.Add(root2.data[i].attributes.display_name);
                    }
                    ExcelOutput.WriteToExcel write = new ExcelOutput.WriteToExcel();
                    write.createExcel(excelStructures, name, answer);
                }
                else
                {
                    Console.WriteLine("There was an error in the search.");
                }
            } while (on);
            //FactaviaAPICall.APICall aPICall = new FactaviaAPICall.APICall();
            //Task<Structures.Root> root =  aPICall.Search("Clam%20Research", "yes");
            //Structures.Root root2 = root.Result;
            //Console.WriteLine("Success");
        }
    }
}
