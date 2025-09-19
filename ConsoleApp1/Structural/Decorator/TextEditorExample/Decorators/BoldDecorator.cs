namespace ConsoleApp1.Structural.Decorator.TextEditorExample.Decorators;

public class BoldDecorator(IText text) : TextDecorator(text)
{
    public override string Render()
    {
        return "<b>" + base.Render() + "</b>";
    }
}
