
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;


/// <summary>
/// Здесь делегат являеться  конструктором в который будут подставляться переменные 
/// </summary>
/// <param name="x"></param>
/// <param name="y"></param>
/// <returns></returns>
public delegate int Delegat(int x, int y); 
/// <summary>
/// Оболочка калькулятора, с заданными действиями
/// </summary>
public class Calculator {
/// <summary>
/// Параметр который возвращает сложение переменных 
/// </summary>
/// <param name="x"></param>
/// <param name="y"></param>
/// <returns></returns>
        public int Plus(int x, int y)
    {
        return x + y;
    }
/// <summary>
/// Параметр который возвращает вычитание переменных
/// </summary>
/// <param name="x"></param>
/// <param name="y"></param>
/// <returns></returns>
        public int Min(int x, int y)
    {
        return x - y;
    }
/// <summary>
/// Параметр который возвращает умножение переменных
/// </summary>
/// <param name="x"></param>
/// <param name="y"></param>
/// <returns></returns>
        public int Mult(int x, int y)
    {
        return x * y;
    }
/// <summary>
/// Параметр который возвращает деление переменных
/// </summary>
/// <param name="x"></param>
/// <param name="y"></param>
/// <returns></returns>
        public int Del(int x, int y)
    {
        return x / y;
    }


}


/// <summary>
/// Класс который запускает программу и в котором вводяться значения для вычисления
/// </summary>
class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();
        Delegat Minus = new Delegat(calculator.Min);
        Delegat Del = new Delegat(calculator.Del);
        Delegat Plus = new Delegat(calculator.Plus);
        Delegat Mult = new Delegat(calculator.Mult);
        Console.WriteLine("Вычитание:" + Minus(214, 12));
        Console.WriteLine("Сложение:" + Plus(10,2));
        Console.WriteLine("Деление:" + Del(521,7));
        Console.WriteLine("Умножение:" + Mult(15, 12));
    }
}