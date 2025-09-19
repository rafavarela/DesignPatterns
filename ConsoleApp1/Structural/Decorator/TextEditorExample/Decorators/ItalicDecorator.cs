namespace ConsoleApp1.Structural.Decorator.TextEditorExample.Decorators;

public class ItalicDecorator(IText text) : TextDecorator(text)
{
    public override string Render()
    {
        return "<i>" + base.Render() + "</i>";
    }
}
