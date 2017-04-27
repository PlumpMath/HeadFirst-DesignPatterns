using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst_DesignPatterns {
    class Program {
        static void Main(string[] args) {
            Duck mallord = new MallordDuck();
            mallord.display();
            mallord.performFly();
            mallord.performQuack();
            Console.ReadKey();

            Duck model = new ModelDuck();
            model.performFly();
            model.setFlyBehavior(new FlyRocketPowered());
            model.performFly();
            Console.ReadKey();

            DuckCallDevice hunterOneDevice = new HunterDuckCallDevice();
            hunterOneDevice.performQuack();
            Console.ReadKey();
        }
    }
}
