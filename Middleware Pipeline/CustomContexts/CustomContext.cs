namespace Middleware_Pipeline.CustomContexts
{
    public class CustomContext
    {
        public String ContextName { get; set; } = "Custom Contest";
        public Dictionary<string, bool> Access { get; set; } = new();
    }
}
