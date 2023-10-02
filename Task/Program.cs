class Program
{
    static void Main(string[] args)
    {
        Person tom = new();
        tom.SayHello();
    }
}
class Person
{
    public void SayHello() => Console.WriteLine("Hello");
}
