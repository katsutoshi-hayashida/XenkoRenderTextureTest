using SiliconStudio.Xenko.Engine;

namespace RenderTextureTest
{
    class RenderTextureTestApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
