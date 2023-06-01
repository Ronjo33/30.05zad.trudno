using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._05zad.trudno
{
    internal class Phonebook
    {
        private PhoneAdd[] entries;

        public Phonebook(int size)
        {
            entries = new PhoneAdd[size];
        }

        public void AddEntry(PhoneAdd entry)
        {
            for (int i = 0; i < entries.Length; i++)
            {
                if (entries[i] == null)
                {
                    entries[i] = entry;

                    Console.WriteLine($"{entry.Name} dobaven e .");

                    return;
                }
            }
            
        }
        public void DelEnt(int id)
        {
            for (int i = 0; i < entries.Length; i++)
            {
                if (entries[i] != null && entries[i].ID == id)
                {
                    entries[i] = null;
                    Console.WriteLine($"{id} 4oveka e iztrit.");

                    for (int j = i; j < entries.Length - 1; j++)
                    {
                        entries[j] = entries[j + 1];
                    }

                    Array.Resize(ref entries, entries.Length - 1);

                    return;
                }
            }
            Console.WriteLine("Joveka ne  e nameren.");
        }

        

        public void DisplayE()
        {
            Console.WriteLine("Phone Book:");
            Console.WriteLine("ID | Name | Address | Phone Number | Rating");

            var sortedEntries = entries.OrderByDescending(entry => entry.Rating);

            foreach (PhoneAdd entry in sortedEntries)
            {
                if (entry != null)
                {
                    Console.WriteLine($"{entry.ID} | {entry.Name} | {entry.Address} | {entry.PhoneNumber} | {entry.Rating}");
                }
            }
        }

        public void DisplayE(PhoneAdd entry)
        {
            Console.WriteLine("ID | Name | Address | Phone Number | Rating");

            if (entry != null)
            {
                Console.WriteLine($"{entry.ID} | {entry.Name} | {entry.PhoneNumber} | {entry.Address} | {entry.Rating}");
            }
        }

        public void SearchById(int id)
        {
            foreach (PhoneAdd entry in entries)
            {
                if (entry != null && entry.ID == id)
                {
                    DisplayE(entry);
                    return;
                }
            }
            Console.WriteLine("Joveka ne  e nameren.");
        }

        
    }
}
