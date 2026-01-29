using Middleware_Pipeline.CustomContexts;
using Middleware_Pipeline.Interfaces;

namespace Middleware_Pipeline.Middlewares
{
    public class SitarMiddleware : IMiddleware
    {
        public void Invoke(CustomContext context, Action next)
        {
            Console.WriteLine($"Sitar Middleware Invoked. Context Name: {context.ContextName}. Tumi Sitar bajate jano?");
            if (context.Access[Contants.SitarMiddleware] == false)
            {
                Console.WriteLine("Sitar bajaite Paro na ekhane ki koro? Jao Rejected tomar request!!");
                return;
            }
            next();
        }
    }
}
