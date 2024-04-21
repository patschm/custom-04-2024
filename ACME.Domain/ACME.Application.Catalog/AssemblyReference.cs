using System.Reflection;

namespace ACME.Application.Catalog;

public static class AssemblyReference
{
    public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;
}