namespace BridgeDesignPattern;

internal class Square : Shape
{
    public Square(IRenderer renderer) : base(renderer) { }

    public override void Draw()
    {
        Console.WriteLine("Drawing a square");
        Renderer.RenderShape();
    }
}