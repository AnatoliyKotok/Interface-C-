using System;
using System.Collections;
using System.Collections.Generic;

namespace Drink_hw
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink whoter = new Drink("Morsh", 1, 15, "Obolon", Drink.TypeDrink.WithoutGas);
            Console.WriteLine(whoter);
            Drink juce = new Drink("Jafa", 2, 34, "Jafa", Drink.TypeDrink.WithoutGas);
            List<Drink> drinks = new List<Drink>{
                new Drink("Pepsi",5,21,"Pepsi",Drink.TypeDrink.WithGas),
                new Drink("Cola", 12, 20, "Cola", Drink.TypeDrink.WithGas),
                new Drink("Sadochok",2,25,"Sadochok",Drink.TypeDrink.WithoutGas)

            };
            Console.WriteLine("Sorted by price");
            drinks.Sort( new CmpPrice());
            foreach (var d in drinks)
            {
                Console.WriteLine(d);
            }
            
            Console.WriteLine("After comparer by call");
            drinks.Sort(new CmpCall());
            foreach (var item in drinks)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("After comparer by producer");
            drinks.Sort(new CmpProd());
            foreach (var item in drinks)
            {
                Console.WriteLine(item);
            }


            ArrayList li = new ArrayList()
            { whoter,juce};
            Console.WriteLine("Sort arrliat by price");
            li.Sort(new CmpPrice());
            for (int i = 0; i < li.Count; i++)
            {
                Console.WriteLine(li[i]);
            }
            
            
            Console.WriteLine("Sort arrliat by call");
            li.Sort(new CmpCall());
            for (int i = 0; i < li.Count; i++)
            {
                Console.WriteLine(li[i]);
            }
            
            
            Console.WriteLine("Sort arrliat by producer");
            li.Sort(new CmpProd());
            for (int i = 0; i < li.Count; i++)
            {
                Console.WriteLine(li[i]);
            }
        }
    }
}
