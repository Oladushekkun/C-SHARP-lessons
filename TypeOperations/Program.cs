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
		//DeterminateHeatLevelByTemperautre(-1	);
		
		//Задача 5 - Определение темпов роста вкладов 
		DefineRevenueGrowth(1000000, 20, 5);
	}
	
	static void CheckEvenNumber(int number)
	{
		Console.WriteLine(number % 2 == 0
			? "Число четное"
			: "Число нечетное");
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
	
	static void DeterminateHeatLevelByTemperautre(double tempC)
	{
		double tempF = tempC * (9.0 / 5.0) + 32;
		
		Console.WriteLine(tempF > 100
			? "Горячо!"
			: tempF < 32
				? "Холодно!"
				:"Нейтрально" );
	}
	
	static void DefineRevenueGrowth(double depositAmount, double interestRate,double depositPeriod)
	{
		double totalAmount = PercentCalculator(depositAmount, interestRate, depositPeriod);
		
		if(totalAmount > (1.5 * depositAmount))
		{
			Console.WriteLine("Хороший рост!");
			return;
		}
		
		Console.WriteLine("Рост умеренный");
	}
	
	static double PercentCalculator(double depositAmount, double interestRate,double depositPeriod)
	{
		double totalAmount = depositAmount * Math.Pow((1 + interestRate / 100), depositPeriod);
		totalAmount = Math.Round(totalAmount, 2);
		
		return totalAmount;
	}
}

//название GetBodyMassIndex
//ввод double mass, double height
//вывод double