using Middleware_Pipeline.CustomContexts;
using Middleware_Pipeline.Interfaces;

namespace Middleware_Pipeline
{
    public class PipeLine
    {
        private readonly List<IMiddleware> _middlewares = new List<IMiddleware>();
        private int _currentMiddlewareIndex = -1;

        public PipeLine Use(IMiddleware middleware)
        {
            _middlewares.Add(middleware);
            return this;
        }

        public void Execute(CustomContext context)
        {
            _currentMiddlewareIndex = -1;
            Next(context);
        }

        private void Next(CustomContext context)
        {
            _currentMiddlewareIndex++;
            if (_currentMiddlewareIndex < _middlewares.Count)
            {
                    _middlewares[_currentMiddlewareIndex].Invoke(context, () => Next(context));
            }
        }
    }
}
