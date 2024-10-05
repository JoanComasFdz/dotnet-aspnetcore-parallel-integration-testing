using System.Reflection;
using Xunit.Abstractions;

namespace ParallelIntegrationTesting;

internal static class TestOutputHelperExtensions
{
    public static string GetTestName(this ITestOutputHelper testOutputHelper)
    {
        var type = testOutputHelper.GetType();
        var testMember = type.GetField("test", BindingFlags.Instance | BindingFlags.NonPublic);
        var value = testMember?.GetValue(testOutputHelper);
        if (value is not ITest test)
        {
            throw new EntryPointNotFoundException("Could not find the test name, make sure you ahve followed all instructions to correctly write your test class.");
        }
        var fullClassName = test.TestCase.TestMethod.TestClass.Class.Name;
        var className = test.TestCase.TestMethod.TestClass.Class.Name.Substring(fullClassName.LastIndexOf('.') + 1);
        return $"{className}.{test.TestCase.TestMethod.Method.Name}";
    }
}