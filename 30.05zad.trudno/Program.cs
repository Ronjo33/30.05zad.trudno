using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._05zad.trudno
{
    internal class Program
    {
        static void Main(string[] args)
        { 
        int size = int.Parse(Console.ReadLine());

            Phonebook book = new Phonebook(size);

            while (true)
            {
                Console.WriteLine("Select Option:");
                Console.WriteLine("1. Add Person");
                Console.WriteLine("2. Delete Person");
                Console.WriteLine("3. Print All");
                Console.WriteLine("4. Search Person");
                Console.WriteLine("5. Exit");
                Console.WriteLine();

                int opciq = int.Parse(Console.ReadLine());

                switch (opciq)
                {
                    case 1:
                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter address: ");
                        string address = Console.ReadLine();

                        Console.Write("Enter rating: ");
                        int rating = int.Parse(Console.ReadLine());

                        PhoneAdd entry = new PhoneAdd(name, address, rating);
                        book.AddEntry(entry);

                        break;

                    case 2:
                        Console.Write("sloji Id na 4ojeka koito iskate da istriete: ");

                        int deleteId = int.Parse(Console.ReadLine());
                        book.DelEnt(deleteId);

                        break;

                    case 3:
                        book.DisplayE();

                        break;
                    case 4:
                        Console.WriteLine("Search Menu:");
                        Console.WriteLine("1. tursene po  ID");

                        int search = int.Parse(Console.ReadLine());

                        switch (search)
                        {
                            case 1:
                                Console.Write("sloji ID za da potursi dali ima takuv  v spisuka: ");
                                int searchId = int.Parse(Console.ReadLine());
                                book.SearchById(searchId);
                                break;
                            default:
                                Console.WriteLine("nevqrna opciq!");
                                break;
                        }

                        break;
                    case 5:
                        Console.WriteLine("brao Priqtel!");

                        return;
                    default:
                        Console.WriteLine("nevqrna opciq!");

                        break;
                }
                Console.WriteLine();

            }
 
        }

    }
}
