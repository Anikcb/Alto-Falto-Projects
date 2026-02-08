using Duck.Interfaces;

namespace Duck.App
{
    public class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Can not quack");
        }
    }
}
