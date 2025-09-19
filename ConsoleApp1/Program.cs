using ConsoleApp1.Structural.Decorator.TextEditorExample;
using ConsoleApp1.Structural.Decorator.TextEditorExample.Decorators;

namespace ConsoleApp1;

public class Program
{
    static void Main(string[] args)
    {
        IText text = new PlainText("Hello world!");
        Console.WriteLine(text.Render());

        text = new BoldDecorator(text);
        Console.WriteLine(text.Render());

        text = new ItalicDecorator(text);
        Console.WriteLine(text.Render());

        text = new UnderlineDecorator(text);
        Console.WriteLine(text.Render());

        Console.ReadKey();
    }
}
