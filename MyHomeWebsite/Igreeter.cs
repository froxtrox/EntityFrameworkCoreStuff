namespace MyHomeWebsite
{
    public interface IGreeter
    {
        string Greet { get; }
    }

    public class Greetings : IGreeter {


        public string Greet => "Greetings from homie.";
    }
}