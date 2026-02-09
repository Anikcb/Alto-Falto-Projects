using Duck.Interfaces;

namespace Duck.App
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Can not fly");
        }
    }
}
