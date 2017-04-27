using System;

namespace HeadFirst_DesignPatterns {
    public class ModelDuck : Duck {
        public ModelDuck() {
            flyBehaviour = new FlyNoWay();
            quackBehaviour = new RealQuack();
        }
        public override void display() {
            Console.WriteLine("I am a Model Duck!");
        }
    }
}