using Interceptors;

namespace System.Runtime.CompilerServices;


public static class GeneratedCode
{
    [InterceptsLocation("C:\\Users\\ArminYaghboubi\\source\\repos\\CSharp12\\Interceptors\\Program.cs", 4, 20)]
    public static string InterceptorMethod(this Example example, string param)
    {
        return $"{param}, Interceptor";
    }
}