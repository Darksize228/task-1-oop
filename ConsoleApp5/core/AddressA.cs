using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.core
{
    public class AddressA
    {
        private int _index;

        public int Index
        {
            get => _index;
            set => _index = value;
        }


        private string _country;

        public string Country
        {
            get => _country;
            set => _country = value;
        }

        private string _city;

        public string City
        {
            get => _city;
            set => _city = value;
        }

        private string _street;

        public string Street
        {
            get => _street;
            set => _street = value;
        }

        private int _house;

        public int House
        {
            get => _house;
            set => _house = value;
        }

        private string _apartment;

        public string Apartment
        {
            get => _apartment;
            set => _apartment = value;
        }
    }
}
