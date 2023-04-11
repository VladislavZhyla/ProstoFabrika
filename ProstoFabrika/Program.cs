using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProstoFabrika
{
    class Program
    {
        public abstract class Building
        {
            public string Material { get; protected set; }

            public abstract void Build();
        }
        public class WoodenHouse : Building
        {
            public WoodenHouse()
            {
                Material = "Дерево";
            }

            public override void Build()
            {
                Console.WriteLine("Створено дерев'яний будинок");
            }
        }

        public class StoneHouse : Building
        {
            public StoneHouse()
            {
                Material = "Камінь";
            }

            public override void Build()
            {
                Console.WriteLine("Створено кам'яний будинок");
            }
        }

        public class BrickHouse : Building
        {
            public BrickHouse()
            {
                Material = "Цегла";
            }

            public override void Build()
            {
                Console.WriteLine("Створено цегляний будинок");
            }
        }
        public interface IBuildingFactory
        {
            Building CreateBuilding();
        }
        public class WoodenHouseFactory : IBuildingFactory
        {
            public Building CreateBuilding()
            {
                return new WoodenHouse();
            }
        }

        public class StoneHouseFactory : IBuildingFactory
        {
            public Building CreateBuilding()
            {
                return new StoneHouse();
            }
        }

        public class BrickHouseFactory : IBuildingFactory
        {
            public Building CreateBuilding()
            {
                return new BrickHouse();
            }
        }

        static void Main(string[] args)
        {
            IBuildingFactory woodenHouseFactory = new WoodenHouseFactory();
            IBuildingFactory stoneHouseFactory = new StoneHouseFactory();
            IBuildingFactory brickHouseFactory = new BrickHouseFactory();

            Building woodenHouse = woodenHouseFactory.CreateBuilding();
            Building stoneHouse = stoneHouseFactory.CreateBuilding();
            Building brickHouse = brickHouseFactory.CreateBuilding();

            woodenHouse.Build();
            stoneHouse.Build();
            brickHouse.Build();
            Console.ReadKey();
        }
    }
    
}
