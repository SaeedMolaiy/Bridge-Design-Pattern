namespace BridgeDesignPattern;

internal class RasterRenderer : IRenderer
{
    public void RenderShape()
    {
        Console.WriteLine("Rendering a shape as a raster image");
    }
}