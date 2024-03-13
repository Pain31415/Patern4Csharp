namespace Patern4Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            IRequestHandler textHandler = new TextRequestHandler();
            IRequestHandler imageHandler = new ImageRequestHandler();

            textHandler.SetNextHandler(imageHandler);

            Request textRequest = new Request("This is a text request");
            Request imageRequest = new Request("This is an image request");

            textHandler.HandleRequest(textRequest);
            textHandler.HandleRequest(imageRequest);
        }
    }
}
