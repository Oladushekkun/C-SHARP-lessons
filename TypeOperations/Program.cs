namespace TypeOperations;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Введите число, чтобы проверить его на четность");
		//CheckEvenNumber(10);
		
		//double result = GetBodyMassIndex(75.5, 1.745);
		//Console.WriteLine(result);
		DetermineBodeQualityByBmi(75.5, 1.930);
    }
	static void CheckEvenNumber(int number)
	{
		if (number % 2 == 0)
		{
			Console.WriteLine("Число четное");
			return;
		}
		
		Console.WriteLine("Число нечетное");
	}
	static double GetBodyMassIndex(double mass, double height)
	{
		double bmi = Math.Round(mass / Math.Pow(height, 2), 2);
		return bmi;
	}
	static void DetermineBodeQualityByBmi(double mass, double height)
	{
		double bmi = GetBodyMassIndex(mass, height);
		
		if (bmi < 18.5)
		{
			Console.WriteLine("Недостаточный вес");
		}
		else if (bmi >= 18.5 && bmi < 24.99)
		{
			Console.WriteLine("Норма");
		}
		else if (bmi >= 25 && bmi < 29.99)
		{
			Console.WriteLine("Избыточный вес");
		}
		else
		{
			Console.WriteLine("Ожирение");
		}
	}
}

//название GetBodyMassIndex
//ввод double mass, double height
//вывод double