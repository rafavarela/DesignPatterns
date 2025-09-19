namespace ConsoleApp1.Structural.Decorator.TextEditorExample.Decorators;

public class UnderlineDecorator(IText text) : TextDecorator(text)
{
    public override string Render()
    {
        return "<u>" + base.Render() + "</u>";
    }
}
