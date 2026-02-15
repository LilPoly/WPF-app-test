/// <summary>
/// Represents the main program class.
/// </summary>
class Program
{
    /// <summary>
    /// The entry point of the application.
    /// Calls the Hello class to display a greeting.
    /// </summary>
    /// <param name="args">
    /// Command-line arguments passed to the application.
    /// </param>
    static void Main(string[] args)
    {
        Hello.SayHello();
    }
}

/// <summary>
/// Provides functionality to display greeting messages.
/// </summary>
class Hello
{
    /// <summary>
    /// Writes "Hello, World!" to the console.
    /// </summary>
    public static void SayHello()
    {
        Console.WriteLine("Hello, World!");
    }
}
