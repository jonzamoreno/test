namespace TestProgram;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Program Start");
            var p = new Program();
            p.Run();
        }
        catch(Exception e)
        {
            Console.WriteLine($"Error : {e}");
        }
        finally
        {
            Console.WriteLine($"Program End");
        }
    }

    void Run()
    {
        MessageBuilder b = new MessageBuilder();
        Console.WriteLine(b.SayHello());
    }
}



