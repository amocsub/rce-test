using System;

class Program
{

    private static string WindowsExecutableFileName => "wkhtmltopdf-0.12.6.0.exe";

    static void Main(string[] args)
    {
        Cli.Wrap("wkhtmltopdf-0.12.6.0.exe");
        var executable = "wkhtmltopdf-0.12.6.0.exe"; 
        Console.WriteLine("Hello, World!");
    }
}
