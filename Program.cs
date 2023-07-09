// See https://aka.ms/new-console-template for more information
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine($"\nЗадача 29. Создание массива из ряда чисел");
Console.Write("Введите числа через запятую : ");
string? seriesOfNumbers = Console.ReadLine();

// запятая для обозначения конца строки
seriesOfNumbers = seriesOfNumbers + ",";    

// удаление пробелов из строки 
string RemovingSpaces (string series){
  string seriesNew = "";
  for (int i = 0; i < series.Length; i++)
  {
    if (series[i] != ' ') 
    {
      seriesNew += series[i];
    }
  }
  return seriesNew;
}

// проверка на правильность ввода 
void СheckNumber2 (int  series){

      if (series == '0'||series == '1'||series == '2'
      ||series == '3'||series == '4'||series == '5'||series == '6'
      ||series == '7'||series == '8'||series == '9'||series == ','
      ||series == '-')
      {
      }
        else {
          Console.WriteLine($"Ошибка ввода. Вводите цифры через запятую.");

      }
}

// создание и заполнение массива из строки
int[] ArrayOfNumbers(string seriesNew){ 

  // инициализация массива из 1 элемента
  int[] arrayOfNumbers = new int[1];    

  int j =0;

  for (int i = 0; i < seriesNew.Length; i++){
    string seriesNew1 = "";

    while (seriesNew[i] != ',' && i < seriesNew.Length){
      seriesNew1 += seriesNew[i];
      СheckNumber2(seriesNew[i]);
      i++;
    }
    // заполнение массива значениями из строки
    arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    
    if (i < seriesNew.Length-1){
      // добавление нового нулевого элемента в конец массива
      arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();    
    }
    j++;
  }
  return arrayOfNumbers;
}

// вывод массива на печать 
void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count){
    Console.Write(coll[index]);
    index++;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 


string seriesNew = RemovingSpaces(seriesOfNumbers);

int[] arrayOfNumbers =  ArrayOfNumbers(seriesNew);

PrintArry(arrayOfNumbers);
