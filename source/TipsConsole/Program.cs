using System;

namespace TipsConsole;

internal class Program
{
    private static void Main(string[] args)
    {

        // a comment that explains something.
        // Generate a jwt token
        string token = GenerateJwtToken();
        Console.WriteLine(token);
        // Generate a sample for base64 encoding
        string base64String = GenerateBase64String("Hello World! Welcome to Visual Studio Tips.");
        Console.WriteLine(base64String);
        // Generate a sample for url encoding
        string urlEncodedString = GenerateUrlEncodedString("https://www.bing.com/search?q=dotnet");
        Console.WriteLine(urlEncodedString);
    }

    private static string GenerateJwtToken()
    {
        return "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c";
    }

    private static string GenerateBase64String(string content)
    {
        return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(content));
    }

    private static string GenerateUrlEncodedString(string content)
    {
        return System.Net.WebUtility.UrlEncode(content);
    }

    private static void AddKeyboardShortcut()
    {

        Console.WriteLine("Add a keyboard shortcut");
        Console.WriteLine("to do a Git pull operation");


    }
    public void ShowDuplicateTool()
    {
        Console.WriteLine("One");
        Console.WriteLine("Two");

        Console.WriteLine("Three");
        Console.WriteLine("Four");
    }
}
