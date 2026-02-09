namespace Duck.App
{
    public class ModelDuck : ADuck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }
        public override void display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
