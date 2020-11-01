using System;
class Program
{
	static int NaturalSum(int num)
	{
		int sum = 0;
		for(int i = 1; i <= num;i++)
		{
			sum += i;
		}
		return sum;
	}
	static int MaxEvenNum(int num)
	{
		int maxEvenNum = 0;
		while(num > 0)
		{
			if(num % 2 == 0)
			{
				maxEvenNum = num;
				break;
			}
			num--;
		}
		if(num > 0)
		{
			return maxEvenNum;
		}
		else
		{
			return -1;
		}
		
		return num;
	}
	static int NumFactorial(int num)
	{
		int factorial = 1;
		for(int i = 1;i <= num;i ++)
		{
			factorial *= i;
		}			
		return factorial;
	}
    static void Main(string[] args)
    {
        Console.WriteLine("Здравствуйте! Вас приветствует математическая программа");
        Console.WriteLine("Данная программа высчитывает факториал введенного числа, показывает максимальное четное число, которое меньше или равно данному, а также показывает сумму всех чисел от 1 до введенного пользователем.");
		bool correctInput = false;
		int userNum = 0;
		while(!correctInput)
		{
			Console.WriteLine("Введите положительное целое число, либо q, если хотите выйти");
			string userInput = Console.ReadLine();
			if (userInput == "q")
			{
				return;
			}
			correctInput = Int32.TryParse(userInput,out userNum);
			if(userNum < 1)
			{
				Console.WriteLine("Число должно быть целым положительным");
			}
		}
        int factorial = NumFactorial(userNum);
		int sum = NaturalSum(userNum);
        int maxEvenNum = MaxEvenNum(userNum);
        Console.WriteLine("Факториал равен " + factorial); 
		Console.WriteLine("Сумма от 1 до N равна " + sum);
        Console.WriteLine("Максимальное четное число меньше N равно " + maxEvenNum);
        Console.ReadLine();
    }
}

