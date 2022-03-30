using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment08JoannaN
{
    class Kennel:IEnumerable<Kennel>
    {
        private Dog[] _dogs;

        public Dog[] Dogs
        {
            get { return _dogs; }
            set { _dogs = value; }
        }

        public Kennel() 
        {
            _dogs = new Dog[0];
        }
        public Kennel(params Dog[] dogList) 
        { 
            _dogs = new Dog[dogList.Length];
            dogList.CopyTo(_dogs, 0);
        }

        /*public IEnumerator<Kennel> GetEnumerator()
        {
            foreach (Dog d in _dogs)
                yield return d;
        }*/

        public Dog this[int offset] 
        {
            get { return _dogs[offset]; }
            set { _dogs[offset] = value;}
        }

        public void Display(string header)
        {
            Console.WriteLine();
            Console.WriteLine(header);
            foreach (Dog d in _dogs)
            {
                Console.WriteLine(d.Name + " " + d.Breed, "{0,-15}\t{1,3}");
            }
        }

        public IEnumerator<Kennel> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
