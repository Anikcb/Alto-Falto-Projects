using Duck.Interfaces;

namespace Duck.App
{
    public class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("Flying duck");
        }
    }
}
