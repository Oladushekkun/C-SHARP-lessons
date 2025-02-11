namespace TypeOperations;

class Program
{
	static void Main(string[] args)
	{
		//Задача 1 - проверка числа на четность
        //Console.WriteLine("Введите число, чтобы проверить его на четность");
		//CheckEvenNumber(10);
		
		//Задача 2 - расчет индекса массы тела и определения качества тела по индексу
		//double result = GetBodyMassIndex(75.5, 1.745);
		//Console.WriteLine(result);
		//DetermineBodeQualityByBmi(75.5, 1.930);
		
		//Задача 3 - Определение високосности года
		//LeapYearOrNot(1900);
		
		//Задача 4 - Конвертации температуры с градусов Цельсия на Фаренгейта
		//double tempC;
		//Console.WriteLine("Введите температуру");
		//tempC = Convert.ToDouble(Console.ReadLine());
		//Temperautre(-1	);
		
		//Задача 5 - Определение темпов роста вкладов 
		PercentCalculator(1000000, 20, 5);
	}
	static void CheckEvenNumber(int number)
	{
		string result = number % 2 == 0
			? "Число четное"
			: "Число нечетное";
		
		Console.WriteLine(result);
		
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
	
	static void PercentCalculator(double depositAmount, double interestRate,double depositPeriod)
	{
		double totalAmount = depositAmount * Math.Pow((1 + interestRate / 100), depositPeriod);
		totalAmount = Math.Round(totalAmount, 2);
		
		if(totalAmount > (1.5 * depositAmount))
		{
			Console.WriteLine("Хороший рост!");
			return;
		}
		Console.WriteLine("Рост умеренный");
	}
}

//название GetBodyMassIndex
//ввод double mass, double height
//вывод double