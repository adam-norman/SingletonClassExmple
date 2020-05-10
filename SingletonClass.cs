using System.Collections.Generic;

public sealed class Singleton
{
    private Singleton()
    {
    }
    private int counter = 0;
    public static Singleton Instance
    {
        get
        {
            return Nested.obj;
        }
    }
    // private nested class.
    private class Nested
    {
        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Nested()
        {
        }

        internal static readonly Singleton obj = new Singleton();
    }
    private Dictionary<int, string> SingletonUses = new Dictionary<int, string>() {
        { 1,"To preserve global state of a type."},
        { 2,"To share common data across application."},
        { 3,"To reduce overhead of instantiating a heavy object again and again."},
        { 4,"Suitable for Facades and Service proxies."},
        { 5,"To cache objects in-memory and reuse them throughout the application."}
    };
    private Dictionary<string, string> SingletonExamples = new Dictionary<string, string>() {
        { "Service Proxies","In an application invoking a service aka API is an extensive operation. And creating a Service client itself time consuming process. By having a Service proxy as a Singleton this overhead can be reduced."},
        { "Facades","Like service proxy, Database connections are another one example where Singleton can be used to produce better performance and synchronization."},
        { "Logs","is a heavier operation, by having a single instance of a Logger, required information can be written to same file as logs."},
        { "Data sharing","Configuration values and any constant values can be kept in Singleton to read by other components of the application."},
        { "Caching","Data fetching is a time taking process whereas caching required data in the application memory avoids DB calls and Singleton can be used here to handle the caching with thread synchronization in an efficient manner comparing to static type."}
    };
    public void whatCanIDo()
    {
        System.Console.WriteLine("Uses:\n");
        foreach (var entry in SingletonUses)
        {
            System.Console.WriteLine($"{entry.Key}-{entry.Value}");
        }
    }
    public void Examples()
    {
        System.Console.WriteLine("Examples:\n");
        foreach (var entry in SingletonExamples)
        {
            System.Console.WriteLine($"{entry.Key}:\n\t{entry.Value}");
        }
    }
    public int Print()
    {
        return ++counter;
    }
}