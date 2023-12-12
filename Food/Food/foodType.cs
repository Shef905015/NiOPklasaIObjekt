using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food
{
    internal class foodType
    {
        string name;
        int protein;
        int carbs;
        int fat;
        static int counter;

        public foodType(string name, int protein, int carbs, int fat)
        {
            this.name = name;
            this.protein = protein;
            this.carbs = carbs;
            this.fat = fat;
            counter++;
        }
        public foodType() { counter++; }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setProtein(int protein)
        {
            this.protein = protein;
        }

        public void setCarbs(int carbs)
        {
            this.carbs = carbs;
        }

        public void setFat(int fat)
        {
            this.fat = fat;
        }

        public string getName()
        {
            return this.name;
        }
        public int getProtein()
        {
            return this.protein;
        }
        public int getCarbs()
        {
            return this.carbs;

        }
        public int getFat()
        {
            return this.fat;
        }
        public int getCounter()
        {
            return counter;
        }

        public override string ToString()
        {
            string ispis = "ime: " + this.getName() + "\nprotein: " + this.getProtein() + "%\n" + "carbs: " + this.getCarbs() + "%" + "\nfat: " + this.getFat() + "%\n";
            return ispis;
        }

    }
}
