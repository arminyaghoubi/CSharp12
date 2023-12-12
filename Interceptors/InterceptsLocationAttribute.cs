namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Method)]
public sealed class InterceptsLocationAttribute(string filePath, int line, int character) : Attribute
{
}

