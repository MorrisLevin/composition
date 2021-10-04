using System;

namespace composition
{
    class Program
    {
        static void Main(string[] args)
        {


            Hero göran = new Hero();
            Hero atom = new Hero();

            Weapon sword = new Weapon();


            Console.WriteLine("This is a fight between Göran and Atom. They will now fight!");


            while (atom.GetAlive() == true && göran.GetAlive() == true)
            {
                atom.hp -= göran.weapon.Attack();
                göran.hp -= atom.weapon.Attack();

                Console.WriteLine($"Göran's HP is now:{göran.hp}");
                Console.WriteLine($"Atom's HP is now:{atom.hp}");
                Console.WriteLine("Click enter to move to the next round!");
                Console.ReadLine();




                if (atom.GetAlive() == false)
                {
                    Console.WriteLine("Göran wins!");
                }
                else if (göran.GetAlive() == false)
                {
                    Console.WriteLine("Atom wins!");
                }
            }




        }
    }
}

