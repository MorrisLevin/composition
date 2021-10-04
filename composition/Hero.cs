using System;

namespace composition
{
    public class Hero
    {

        public int hp = 100;

        public Weapon weapon = new Weapon();



        public bool GetAlive()
        {
            return hp > 0;
        }





    }
}