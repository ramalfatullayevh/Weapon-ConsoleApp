using WeaponTask.Models;

namespace WeaponTask
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Weapon weapon = new Weapon(5, 2, 30, true);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|----------------   User Menu   ----------------|");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" 0)Informasiya almaq \n 1)Shoot metodu \n 2)Fire metodu \n 3)GetRemainBulletCount metodu \n 4)Reload metodu \n 5)ChangeFireMode metodu \n 6)Proqramdan dayandırmaq");
            bool repeat = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("|-----------------------------------------------|");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        weapon.GetInfo();
                        break;
                                              
                    case 1:
                        weapon.Shoot();
                        break;
                    case 2:
                        weapon.Fire();
                        break;
                    case 3:
                        Console.WriteLine("Daragin dolmasi ucun lazim olan gulle sayi " + weapon.GetRemainBulletCount()); 
                        break;
                    case 4:
                        weapon.Reload();
                        break;
                    case 5:
                        weapon.ChangeFireMode();
                        break;
                    case 6:
                        Console.WriteLine("Proramdan cixish edildi");
                        break;
                    case 7:
                        repeat = true;
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
            } while (!repeat);
        }

    }

}