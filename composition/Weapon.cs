using System;

namespace composition
{
    public class Weapon
    {

        private Random generator = new Random();
        public string namn = "Excalibur";


        public int Attack()
        {

            int i = generator.Next(1, 20);


            return i;
        }




    }
}