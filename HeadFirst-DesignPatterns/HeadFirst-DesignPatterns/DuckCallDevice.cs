using System;

namespace HeadFirst_DesignPatterns {
    public abstract class DuckCallDevice {
        protected QuackBehaviour mimicedQuackBehaviour;
        public abstract void performQuack();
    }
}