using Linq.Services;

class Program
{
    static void Main()
    {
        JoinService service = new JoinService();
        service.ShowJoinResult();

        Console.ReadLine();
    }
}