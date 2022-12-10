// // Задача 64: Задайте значения M и N. Напишите программу, 
// // которая выведет все натуральные числа в промежутке от M до N.
// 		// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// 		// M = 4; N = 8. -> ""4, 6, 7, 8""
		
// 		void PrintInterval(int m, int n)
// 		{
// 			int start = m;
// 			int end = n;
// 			if(m > n)
// 			{
// 				start = n;
// 				end = m;
// 			}
// 			for(int i = start; i <= end; i++)
// 			{
// 				Console.Write($"{i} ");
// 			}
// 		}
// 		PrintInterval(22, 9);
		
// 		Console.WriteLine();
		
// 		// Задача 66: Задайте значения M и N. Напишите программу,
//         //  которая найдёт сумму натуральных элементов в промежутке от M до N.
// 		// M = 1; N = 15 -> 120
// 		// M = 4; N = 8. -> 30
		
// 		int CalculateSumm(int m, int n)
// 		{
// 			int start = m;
// 			int end = n;
// 			if(m > n)
// 			{
// 				start = n;
// 				end = m;
// 			}
// 			return (end + start)*(end - start + 1)/2; // по формуле суммы членов арифметической прогрессии
// 		}
		
// 		Console.WriteLine(CalculateSumm(72, 16));
	
//     // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//     //  Даны два неотрицательных числа m и n.
	
		
// 		int AkkermanFunc(int m, int n)
// 		{
// 			if(m == 0)
// 			{
// 				return n + 1;
// 			}
// 			if(m > 0 && n == 0)
// 			{
// 				return AkkermanFunc(m - 1, 1);
// 			}
// 			return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
// 		}
		
// 		Console.WriteLine(AkkermanFunc(3,2));

// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

System.Console.WriteLine(PrintNumbers(0, 10));

string PrintNumbers(int start, int end)

{

    if (start == end)

    {

        return start.ToString();

    }
    return (start + " " + PrintNumbers(++start, end));

}
