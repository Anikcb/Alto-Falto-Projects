namespace Duck.App
{
    public class MiniDuckSimulator
    {
        public void Simulate()
        {
            ADuck mallardDuck = new MallardDuck();
            mallardDuck.PerformQuack();
            mallardDuck.PerformFly();

            ADuck modelDuck = new ModelDuck();
            modelDuck.PerformFly();
            modelDuck.SetFlyBehavior(new FlyRocketPowered());
            modelDuck.PerformFly();
        }
    }
}
