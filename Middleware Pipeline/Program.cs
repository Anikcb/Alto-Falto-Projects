using Middleware_Pipeline;
using Middleware_Pipeline.CustomContexts;
using Middleware_Pipeline.Middlewares;

var pipeLine = new PipeLine();
pipeLine
    .Use(new GuitarMiddleware())
    .Use(new SitarMiddleware())
    .Use(new ViolinMiddleware());

var context = new CustomContext();
context.ContextName = "Ghorar Dim";
context.Access.Add(Contants.GuitarMiddleware, true);
context.Access.Add(Contants.SitarMiddleware, true);
context.Access.Add(Contants.ViolinMiddleware, false);
pipeLine.Execute(context);

