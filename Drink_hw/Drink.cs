using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Drink_hw
{
    class Drink: IComparable, IComparable<Drink>
    {
        
        public enum TypeDrink { HotDrinc = 0, ColdDrinc, WithGas, WithoutGas };
        TypeDrink type = TypeDrink.ColdDrinc;
        

        public Drink(string name, uint call, uint price,string producer, TypeDrink drink)
        {
            this.Name = name;
            this.Call = call;
            this.Price = price;
            this.Producer = producer;
            this.type = drink;
        }
        public string Name { 
            get;
            set; 
        }
        public uint Call { get; set; }
        public uint Price { get; set; }
        public string Producer { get; set; }
        public override string ToString()
        {
            return $"{Name}\t{type}\t{Call}\t{Price}\t{Producer}";
        }

        public int CompareTo(object obj)
        {
            if (obj == null)

                throw new ArgumentNullException("Other object is null");
            if (!(obj is Drink))
                throw new ArgumentNullException("other object not Car");
            Drink drink = (Drink)obj;
            return this.type.CompareTo(drink.type);
        }

        public int CompareTo( Drink other)
        {
            return this.Name.CompareTo(other.Name); ;
        }
    }
    class CmpPrice :IComparer<Drink>,IComparer
    {
        

        public int Compare(object x, object y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentNullException("Object is null");
            }
            if (!(x is Drink) || !(y is Drink))
            {
                throw new ArgumentNullException("Is not car");
            }
            Drink d1 = (Drink)x;
            Drink d2 = (Drink)y;

            return d1.Price.CompareTo(d2.Price);
        }

        public int Compare([AllowNull] Drink x, [AllowNull] Drink y)
        {
            return x.Price.CompareTo(y.Price);
        }

        
    }
    class CmpCall : IComparer<Drink>,IComparer
    {


        public int Compare(object x, object y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentNullException("Object is null");
            }
            if (!(x is Drink) || !(y is Drink))
            {
                throw new ArgumentNullException("Is not car");
            }
            Drink d1 = (Drink)x;
            Drink d2 = (Drink)y;

            return -d1.Call.CompareTo(d2.Call);
        }

        public int Compare([AllowNull] Drink x, [AllowNull] Drink y)
        {
            return -x.Price.CompareTo(y.Price);
        }

    }
    class CmpProd :IComparer<Drink>, IComparer
    {


        public int Compare(object x, object y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentNullException("Object is null");
            }
            if (!(x is Drink) || !(y is Drink))
            {
                throw new ArgumentNullException("Is not car");
            }
            Drink d1 = (Drink)x;
            Drink d2 = (Drink)y;

            return d1.Producer.CompareTo(d2.Producer);
        }
        public int Compare([AllowNull] Drink x, [AllowNull] Drink y)
        {
            return x.Price.CompareTo(y.Price);
        }
    }
}
