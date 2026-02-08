using Duck.Interfaces;

namespace Duck.App
{
    public class Quack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("QUACK QUACK");
        }
    }
}
