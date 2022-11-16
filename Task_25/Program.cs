// Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Для решения задания использование цикла for является обязательным условием. Не использовать встроенный метод возведения в степень.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Exponentiation(int numberA, int numberB){
  int result = 1;
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
  }
    // int result = Math.Pow(numberA, numberB);
    return result;
}

  Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(numberA, numberB);
if (exponentiation > 2){
     Console.WriteLine("Ответ: " + exponentiation);
  } else {
    Console.WriteLine($"Введите числа больше 1!");
  }
  