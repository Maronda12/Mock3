using System;
using System.Collections.Generic;

namespace MockAssessment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test methods
            Town t = new Town();
            

            Console.WriteLine(t.Harvest());
            Console.WriteLine(t.CalcFoodConsumption());
            Console.WriteLine(t.SurviveTheWinter());
        }

    }

    public class Town
    {
        //Property
        public List<Villager> Villagers
        {
            get; set;
        }

        //Constructor
        public Town()
        {
            Villagers = new List<Villager>();
            Villagers.Add(new Farmer());
            Villagers.Add(new Slacker());
            Villagers.Add(new Slacker());
            Villagers.Add(new Slacker());
        }

        //Method 1
        //Finds the total of all Villagers'Farm() methods,returns total
        public int Harvest()
        {
            int total = 0;
            foreach (Villager v in Villagers)
            {
                total += v.Farm();
            }
            return total;
        }

        //Method 2
        //Finds the total of all Villagers'Hunger properties,returns total
        public int CalcFoodConsumption()
        {
            int total = 0;
            foreach (Villager h in Villagers)
            {
                total += h.Hunger;
            }
            return total;
        }



        //Method 3
        //Store results of methods above, return true or false 
        public bool SurviveTheWinter()
        {
            int harvesttotal = Harvest();
            int hungertotal = CalcFoodConsumption();

            if (hungertotal <= harvesttotal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }

    public abstract class Villager
    {
        //Property
        public int Hunger { get; set; }

        //Method
        public abstract int Farm();


    }

    class Farmer : Villager
    {
        //Constructor
        public Farmer()
        {
            Hunger = 1;
        }
        //Method
        public override int Farm()
        {
            return 2;
        }
    }

    class Slacker : Villager
    {
        //Constructor
        public Slacker()
        {
            Hunger = 3;
        }
        //Method
        public override int Farm()
        {
            return 0;
        }
    }

}