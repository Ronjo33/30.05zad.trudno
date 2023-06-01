using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._05zad.trudno
{
    internal class PhoneAdd
    {
        private static Random rnd = new Random();      
          
        private static int nextId = 1;
        public int ID { get; }


        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        private string address;
        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }
        
        private string phoneNumber;
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                this.phoneNumber = value;
            }
        }
        
        private int rating;
        public int Rating
        {
            get
            {
                return this.rating;
            }
            set
            {
                this.rating = value;
            }
        }

        public PhoneAdd(string name, string address, int rating)
        {
            ID = nextId++;
            this.Name = name;
            this.Address = address;
            this.Rating = rating;
            this.PhoneNumber = SustavqneNaPhoneNum();
        }

        private string SustavqneNaPhoneNum()
        {
            long number = rnd.Next(100000000, 900000000);
            return "0" + number.ToString();
        }

    }
}
