namespace HeadFirst_DesignPatterns {
    public class HunterDuckCallDevice : DuckCallDevice {
        public HunterDuckCallDevice() {
            mimicedQuackBehaviour = new RealQuack();
        }
        public override void performQuack() {
            mimicedQuackBehaviour.quack();
        }
    }
}