using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.SpawnEnemy("Mage");
            client.SpawnEnemy("Warrior");
            Console.ReadKey();
        }


       
    }

    class Client 
    {
        IEnemyFactory spawner = null;

        public void SpawnEnemy(string enemy)
        {
            switch(enemy.ToLower())
            {
                case "mage":
                    spawner = new Mage(); Console.WriteLine("Появился новый враг - Маг\nОн снаряжен:"); break;
                case "warrior":
                    spawner = new Warrior(); Console.WriteLine("Появился новый враг - Воин\nОн снаряжен:"); break;
            }
            Console.WriteLine(spawner.GetArmor().Item());
            Console.WriteLine(spawner.GetWeapon().Item());
            Console.WriteLine("___________________________________________________________");
        }
    }

}
