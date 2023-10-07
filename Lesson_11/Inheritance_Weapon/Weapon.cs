namespace Inheritance_Weapon
{
    internal class Weapon // Base class for all weapon types 
    {

        public virtual void Attack()
        {
            Console.WriteLine("Attack");
        }
    }
}
