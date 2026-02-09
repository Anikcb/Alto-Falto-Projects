using Duck.Interfaces;

namespace Duck.App
{
    public abstract class ADuck
    {

        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;

        public abstract void display();


        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.quack();
        }

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }
        public void SetQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }

        public void Swim()
        {
            Console.WriteLine($"This duck can swim");
        }
    }
}
