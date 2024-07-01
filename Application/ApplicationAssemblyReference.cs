// ApplicationAssemblyReference.cs04:0704:07

using System.Reflection;

namespace Application;

public class ApplicationAssemblyReference
{
    internal static readonly Assembly Assembly = typeof(ApplicationAssemblyReference).Assembly;
}