using System.Reflection;

namespace ACME.Application.Reviews;

public static class AssemblyReference
{
    public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;
}