using Middleware_Pipeline.CustomContexts;
using System;

namespace Middleware_Pipeline.Interfaces
{
    public interface IMiddleware
    {
        public void Invoke(CustomContext context, Action next);
    }
}
