namespace Patern4Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            IMediator mediator = new ConcreteMediator();

            // Створюємо колег
            Colleague colleague1 = new ConcreteColleague(mediator);
            Colleague colleague2 = new ConcreteColleague(mediator);

            ((ConcreteMediator)mediator).AddColleague(colleague1);
            ((ConcreteMediator)mediator).AddColleague(colleague2);

            colleague1.SendMessage("Hello from colleague 1!");
        }
    }
}
