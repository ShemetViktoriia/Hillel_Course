namespace Inheritance_Weapon
{
    internal class Knife : Weapon
    {
        public override void Attack()
        {
            // base()
            // base.Attack();
            Console.WriteLine("Attack with knife");
        }
    }
}
