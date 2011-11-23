using FubuMVC.Core;

namespace Bug
{
    public class CustomFubuRegistry : FubuRegistry
    {
        public CustomFubuRegistry() : this(false) { }
        public CustomFubuRegistry(bool diagnostics)
        {
            IncludeDiagnostics(diagnostics);

            Applies.ToThisAssembly();

            Actions
                .IncludeTypesNamed(t => t.EndsWith("Python"))
                .IncludeMethods(m => m.Name.Equals("Command"))
                .IncludeMethods(m => m.Name.Equals("Query"));
        }
    }
}