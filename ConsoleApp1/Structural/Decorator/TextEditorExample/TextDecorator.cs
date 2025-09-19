namespace ConsoleApp1.Structural.Decorator.TextEditorExample;

public abstract class TextDecorator(IText text) : IText
{
    public virtual string Render()
    {
        return text.Render();
    }
}
