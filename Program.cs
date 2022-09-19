// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// Запрос данных от пользователя 
int ReadData(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "1");
    return num;
}

// // Вывод результата
// void PrintData(string prefix, string num)
// {     
//     Console.WriteLine(prefix + num);
// } 

// // Числа в промежутке 
// string NumMN(int m, int n)
// {
//     // точка остановки
//     if (m >= n)
//     {  
//         string result = Convert.ToString(n);
//         return result;
//     }
//     else
//     {
//         // рекурентный вызов
//         string res = m + ", " + NumMN(m+1, n);
//         return res;
//     }
// }

// int m = ReadData("Введите число m: "); 
// int n = ReadData("Введите число n: "); 

// string res = (m < n)? NumMN(m,n): NumMN(n,m);

// PrintData("Все натуральные числа в промежутке: ", res);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Вывод результата
void PrintData(string prefix, int num)
{
    Console.WriteLine(prefix + num);
}

// // сумма чисел в промежутке 
// int SumMN(int m, int n)
// {
//     // точка остановки
//     if (m >= n)
//     {  
//         int result = n;
//         return result;
//     }
//     else
//     {
//         // рекурентный вызов
//         int res = m + SumMN(m+1, n);
//         return res;
//     }
// }

// int m = ReadData("Введите число m: "); 
// int n = ReadData("Введите число n: "); 
// int sum = 0;    
// if(m < n)
// {
//     sum = SumMN(m,n);
// }
// else
// {
//     sum = SumMN(n,m);
// }

// PrintData("Сумма чисел в промежутке = ", sum);


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Вычисление функции Аккермана
int Ackerman(int m, int n)
{
    // точка остановки
    if (m == 0) return n + 1;
    else if (n == 0) return Ackerman(m - 1, 1);
    else return Ackerman(m - 1, Ackerman(m, n - 1));
}

int m = ReadData("Введите число m: ");
int n = ReadData("Введите число n: ");

if (m < 0 || n < 0)
{
    Console.WriteLine("Числа должны быть неотрицательные");
}
else
{
    PrintData("A(m,n) = ", Ackerman(m,n));
}


