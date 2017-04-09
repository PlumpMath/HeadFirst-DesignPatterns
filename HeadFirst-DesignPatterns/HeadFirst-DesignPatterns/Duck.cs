namespace HeadFirst_DesignPatterns {
    public abstract class Duck {
        protected QuackBehaviour quackBehaviour;
        protected FlyBehaviour flyBehaviour;

        public abstract void display();
        public void performFly() {
            flyBehaviour.fly();
        }
        public void performQuack() {
            quackBehaviour.quack();
        }
    }
}