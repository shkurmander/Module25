using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаем разные типы аккаунтов
            var baseAcc = new BaseAccount(30000);
            var baseAcc1 = new BaseAccount(500);
            var salaryAcc = new SalaryAccount(60000);

            //вызываем калькулятор для данных аккаунтов.
            Calculator.CalculateInterest(baseAcc);
            Calculator.CalculateInterest(baseAcc1);
            Calculator.CalculateInterest(salaryAcc);

            Console.ReadKey();
        }
    }
}
