using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CourierManagementSystem1
{
    class Program
    {

        static void MyMethod()
        {
            Console.WriteLine("\nItem Number 01");
            Console.WriteLine("Shipper Info: Wald Balallo");
            Console.WriteLine("Receiver Info: Juan Dela Cruz");
            Console.WriteLine("Address Info: Sta. Rosa, Laguna");
        }

        static void MyMethod1()
        { 
            Console.WriteLine("\nItem Number 02");
            Console.WriteLine("Shipper Info: Hisoka Morow");
            Console.WriteLine("Receiver Info: Killua Zoldyck");
            Console.WriteLine("Address Info: Greed Island");
        }

        static void Main(string[] args)
        {
            string optionSelected = "yes", itemInfo, shipperInfo, receiverInfo, addressInfo, editedInfo;
            List<string> editInfo = new List<string>() {"Item Number 1","Wald Balallo","Juan Dela Cruz","Sta. Rosa, Laguna"};
            int infoIndex, numInfo;
            

            string textToShow = "Courier Management System\n\n";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToShow.Length / 2)) + "}", textToShow));

            Console.WriteLine("Press Enter once to Login :')\n");
            Console.ReadKey();

            Console.WriteLine("Login Form");
            Console.WriteLine("============\n");

            int loginAttempts = 0;
 

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Username: ");
                String user = Console.ReadLine();

                Console.WriteLine("Enter Password: ");
                String pass = Console.ReadLine();

                if (user != "user" || pass != "pass")
                    loginAttempts++;
                else
                    break;
            }

            if (loginAttempts > 2)
            {
                Console.WriteLine("\tYour username or password is incorrect.\t");
                Console.WriteLine("\t===========\n");
            }
            else
            {
                Console.WriteLine("\tLogin Success!\t");
                Console.WriteLine("\t==============\n\n");
                Console.WriteLine("Press Enter once to show the command :')\n");
                Console.ReadKey();


                do
                {
                    Console.WriteLine("\n\nPick a Command Number:\t");
                    Console.WriteLine("**********************\n\n");

                    Console.WriteLine("1. Shipment info");
                    Console.WriteLine("2. Edit/Update Shipment");
                    Console.WriteLine("3. List all Shipment");
                    Console.WriteLine("4. Search By Item Number\n");

                    Console.WriteLine("Enter your choice: ");
                    String choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        Console.WriteLine("\n\tShipment info");
                        Console.WriteLine("\t=============\n\n");
                        Console.Write("Enter Item Number: ");
                        itemInfo = Console.ReadLine();
                        Console.Write("Enter Shipper Info: ");
                        shipperInfo = Console.ReadLine();
                        Console.Write("Enter Receiver Info: ");
                        receiverInfo = Console.ReadLine();
                        Console.Write("Enter Address Info: ");
                        addressInfo = Console.ReadLine();

                        Console.WriteLine("\t\nSuccessfully added new Shipment Info!");
                        Console.WriteLine("=====================================\n");

                        Console.WriteLine("\nItem Number: " +itemInfo);
                        Console.WriteLine("Shipper Information: " +shipperInfo);
                        Console.WriteLine("Receiver Information: " +receiverInfo);
                        Console.WriteLine("Address Information: " +addressInfo);

                        Console.WriteLine("\n\nDo you want to go back Menu?");
                        optionSelected = Console.ReadLine().ToLower();

                    }

                    if (choice == "2")
                    {
                        Console.WriteLine("\n\tEdit/Update Shipment");
                        Console.WriteLine("\t======================\n\n");
                        numInfo = 1;
                        foreach (var listofshipmentinfo in editInfo)
                        {
                            Console.WriteLine(numInfo + "-" + listofshipmentinfo);
                            numInfo++;
                        }
                        Console.WriteLine("\nEnter number to edit: ");
                        infoIndex = int.Parse(Console.ReadLine());
                        

                        Console.WriteLine("\nEnter your new info: ");
                        editedInfo = Console.ReadLine();
                        editInfo.RemoveAt(infoIndex - 1);
                        editInfo.Insert(infoIndex-1, editedInfo);

                        Console.WriteLine("\n\nDo you want to go back Menu?");
                        optionSelected = Console.ReadLine().ToLower();
                    }


                    if (choice == "3")
                    {
                        Console.WriteLine("Press Enter to View the List of Shipment!\n");
                        Console.ReadKey();

                        Console.WriteLine("\n\tList all Shipment");
                        Console.WriteLine("\t===================\n\n");

                        MyMethod();
                        MyMethod1();

                        Console.WriteLine("\n\nDo you want to go back Menu?");
                        optionSelected = Console.ReadLine().ToLower();
                    }

                    if (choice == "4")
                    { 

                            Console.WriteLine("\n\tSearch By Item Number");
                            Console.WriteLine("\t==============================\n\n");

                            Console.WriteLine("Please Type the Item Number: ");
                            string itemNumber = Console.ReadLine();

                            if (itemNumber == "01")
                            {
                                MyMethod();
                            }

                            if (itemNumber == "02")
                            {
                                MyMethod1();
                            }

                            else
                            {
                                Console.WriteLine("\n\tInvalid Item Number!");
                                Console.ReadKey();         
                            }

                            Console.WriteLine("\n\nDo you want to go back Menu?");
                            optionSelected = Console.ReadLine().ToLower();
                    }
                } while (optionSelected.Equals("yes")); 
            }
            Console.ReadKey();
        }
    }
}
