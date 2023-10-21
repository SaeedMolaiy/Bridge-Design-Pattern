namespace BridgeDesignPattern;

internal class Circle : Shape
{
    public Circle(IRenderer renderer) : base(renderer) { }

    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
        Renderer.RenderShape();
    }
}