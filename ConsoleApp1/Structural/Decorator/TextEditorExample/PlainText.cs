namespace ConsoleApp1.Structural.Decorator.TextEditorExample;

public class PlainText(string text) : IText
{
    public string Render()
    {
        return text;
    }
}
