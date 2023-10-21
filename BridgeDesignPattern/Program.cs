
using BridgeDesignPattern;

IRenderer vectorRenderer = new VectorRenderer();
IRenderer rasterRenderer = new RasterRenderer();

Shape circle = new Circle(vectorRenderer);
Shape square = new Square(rasterRenderer);

circle.Draw();
square.Draw();

Console.ReadKey();