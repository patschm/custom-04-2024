using System.Reflection;

namespace ACME.Database.EntityFramework;

public static class AssemblyReference
{
    public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;
}