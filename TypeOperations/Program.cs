namespace TypeOperations;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Введите число, чтобы проверить его на четность");
		//CheckEvenNumber(10);
		
		//double result = GetBodyMassIndex(75.5, 1.745);
		//Console.WriteLine(result);
		//DetermineBodeQualityByBmi(75.5, 1.930);
		//LeapYearOrNot(1900);
		
			//double tempC;
			//Console.WriteLine("Введите температуру");
			//tempC = Convert.ToDouble(Console.ReadLine());
			Temperautre(-1);
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
	static void LeapYearOrNot(double year)
	{
		if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
		{
			Console.WriteLine("Год високосный");
			return;
		}
		Console.WriteLine("Год не високосный");
		
	}
	static void Temperautre(double tempC)
	{
		double tempF = tempC * (9 / 5) + 32;
		if(tempF > 100)
		{
			Console.WriteLine("Горячо!");
			return;
		}
		
		else if(tempF < 32)
		{
			Console.WriteLine("Холодно!");
			return;
		}
		Console.WriteLine("Нейтрально");
	}
}

//название GetBodyMassIndex
//ввод double mass, double height
//вывод double