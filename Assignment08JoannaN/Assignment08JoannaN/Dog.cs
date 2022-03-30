using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment08JoannaN
{
    class Dog: IComparable<Dog>
    {
        private string _name;
        private string _breed;
        private static IComparer<Dog> _byBreed;

        public Dog() { Name = "no name"; Breed = "unknown breed"; }
        public Dog(string n, string b) { Name = n; Breed = b; }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Breed
        {
          get { return _breed; }
          set { _breed = value; }
        }

        public int CompareTo(Dog other)
        {
            return this.Name.CompareTo(other.Name);
        }

        public static IComparer<Dog> SortByBreed{
            get 
            {
                if (_byBreed == null)
                    _byBreed = new BreedComparer();
                return _byBreed;
            }
        }
        private class BreedComparer : IComparer<Dog>
        {
            public int Compare(Dog x, Dog y)
            {
                return x.Breed.CompareTo(y.Breed);
            }
        }
    }
}
