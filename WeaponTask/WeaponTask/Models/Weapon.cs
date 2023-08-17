using System.ComponentModel.Design;

namespace WeaponTask.Models
{
    internal class Weapon
    {
        int _bulletCapacity;
        int _bulletCount;
        int _dischargeTime;
        bool _isAuto;


        public int  BulletCapacity
        {
            get { return _bulletCapacity; }
            set 
            {
                if (value>0)
                {
                    _bulletCapacity = value;
                }
            }
        }

        public int BulletCount
        {
            get { return _bulletCount; }
            set
            {
                if (value > 0)
                {
                    _bulletCount = value;
                }
            }
        }

        public int DischargeTime
        {
            get { return _dischargeTime; }
            set
            {
                if (value > 0)
                {
                    _dischargeTime = value;
                }
            }
        }

        public bool  IsAuto
        {
            get { return _isAuto; }
            set
            {
                _isAuto = value;
            }
        }

        public Weapon(int bulletcapacity, int bulletcount , int dischargetime, bool isauto)
        {
            BulletCapacity = bulletcapacity;
            BulletCount = bulletcount;
            DischargeTime = dischargetime;
            IsAuto = isauto;
        }


        public void Shoot()
        {
            if (BulletCount!=0)
            {
                Console.WriteLine("Gulle atildi");
                BulletCount--;
                if (BulletCount<=1)
                {
                    Console.WriteLine("Daraqda gulle bitdi. Yeniden Gulle doldurulur...");
                    Reload();
                }

        }
         }

        public void Fire()
        {
            if (IsAuto!=true)
            {
                if (BulletCount != 0)
                {
                    Console.WriteLine("Tekli modda atis edildi: ");
                    BulletCount--;
                }
                else
                {
                    Console.WriteLine("Daraqda gulleniz yoxdur!");
                }
            }
            else
            {
                if (BulletCount != 0)
                {
                    int fireTime = DischargeTime / BulletCapacity;
                    Console.WriteLine($"Daraqdaki ggulleler ateshlendi ve : {BulletCount * fireTime} saniyede bitdi ");
                    
                }
                else
                {
                    Console.WriteLine("Daraqda gulleniz yoxdur!");
                }
            }
        }


        public int GetRemainBulletCount()
        {
             int remainBullet = (BulletCapacity - BulletCount);
             return remainBullet;
        }


        public void Reload()
        {
            if (BulletCount!=BulletCapacity)
            {
                BulletCount = BulletCount + GetRemainBulletCount();
                Console.WriteLine("Daraq tam doldu.");
            }
        }

        public void ChangeFireMode()
        {
            
            if(IsAuto)
            {
                IsAuto = false;
                Console.WriteLine("Mod deyishdi Tekli moda kechildi");
            }
            else
            {
                IsAuto = true;
                Console.WriteLine("Mode deyishdi Auto moda kechildi.");
            }
        }


        public void GetInfo()
        {
            Console.WriteLine($"Bullet Capacity: {BulletCapacity}\nBullet Count: {BulletCount}\nDischarge Time: {DischargeTime}");
            if (IsAuto)
            {
                Console.WriteLine("Auto");
            }
            else
            {
                Console.WriteLine("Tekli");
            }
        }



    }
}

   
