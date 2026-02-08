using Duck.Interfaces;

namespace Duck.App
{
    public class Squeak : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
