namespace FirstProject;

class Program
{
    static void Main(string[] args)
    {
		var first = Convert.ToDouble(args[0]);
		var second = Convert.ToDouble(args[1]);
		
		Console.WriteLine(Math.Sqrt( first + second));
    }
}
