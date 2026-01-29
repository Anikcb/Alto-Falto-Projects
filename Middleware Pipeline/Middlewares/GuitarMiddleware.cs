using Middleware_Pipeline.CustomContexts;
using Middleware_Pipeline.Interfaces;

namespace Middleware_Pipeline.Middlewares
{
    public class GuitarMiddleware : IMiddleware
    {
        public void Invoke(CustomContext context, Action next)
        {
            Console.WriteLine($"Guitar Middleware Invoked. Context Name: {context.ContextName}. Tumi Guitar bajate jano?");
            if (context.Access[Contants.GuitarMiddleware] == false)
            {
                Console.WriteLine("Guitar bajaite Paro na ekhane ki koro? Jao Rejected tomar request!!");
                return;
            }
            next();
        }
    }
}
