using Duck.Interfaces;

namespace Duck.App
{
    public class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("Can not fly");
        }
    }
}
