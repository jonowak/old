using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment08JoannaN
{
    class MainClass
    {
         static void Main(string[] args)
        {
            Dog[] dogs = {
                 new Dog("Buddy", "Jack Russell"),
                 new Dog("Max", "Yorkshire Terrier"),
                 new Dog("Rocky","Boxer"),
                 new Dog("Jack", "Poodle"),
                 new Dog("Cody", "German Shepherd")
                         };

             Kennel dogKennel = new Kennel(dogs);
             dogKennel.Display("Dogs in the Kennel not sorted.");
             Array.Sort(dogKennel.Dogs);
             dogKennel.Display("Dogs in the Kennel sorted by name.");
             Array.Sort(dogKennel.Dogs, Dog.SortByBreed);
             dogKennel.Display("Dogs in the Kennel sorted by breed.");
             
        }
    }
}
