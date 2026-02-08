using Duck.Interfaces;

namespace Duck.App
{
    public abstract class ADuck
    {

        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;

        public abstract void display();


        public void performFly()
        {
            flyBehavior.fly();
        }

        public void performQuack()
        {
            quackBehavior.quack();
        }

        public void swim()
        {
            Console.WriteLine($"This duck can swim");
        }
    }
}
