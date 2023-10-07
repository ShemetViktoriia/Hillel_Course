namespace Inheritance_Weapon
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon knife = new Knife();
            knife.Attack();

            Weapon gun = new Gun();
            gun.Attack();

            Weapon granata = new Granata();
            granata.Attack();

        }
    }
}

