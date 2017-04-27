using System;

namespace HeadFirst_DesignPatterns {
    internal class FlyNoWay : FlyBehaviour {
        public void fly() {
            Console.WriteLine("I can't fly");
        }
    }
}