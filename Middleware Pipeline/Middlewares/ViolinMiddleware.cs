using Middleware_Pipeline.CustomContexts;
using Middleware_Pipeline.Interfaces;

namespace Middleware_Pipeline.Middlewares
{
    public class ViolinMiddleware : IMiddleware
    {
        public void Invoke(CustomContext context, Action next)
        {
            Console.WriteLine($"Violinv Middleware Invoked. Context Name: {context.ContextName}. Tumi Violin bajate jano?");
            if (context.Access[Contants.ViolinMiddleware] == false)
            {
                Console.WriteLine("Violin bajaite Paro na ekhane ki koro? Jao Rejected tomar request!!");
                return;
            }
            next();
        }
    }
}
