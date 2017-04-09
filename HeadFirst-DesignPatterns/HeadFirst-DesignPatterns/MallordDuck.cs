using System;

namespace HeadFirst_DesignPatterns {
    public class MallordDuck : Duck {
        public MallordDuck() {
            quackBehaviour = new RealQuack();
            flyBehaviour = new FlyWithWings();
        }
        public override void display() {
            Console.WriteLine("I am a Mallord Duck");
        }
    }
}