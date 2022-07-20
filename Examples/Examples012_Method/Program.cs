// Виды методов
//Вид 1 (ни чего не возвращает, ни чего не принимает)
/*
void method1()
{
    Console.WriteLine("Author ......");
}
method1();

//Вид 2(методы которые ни чего не возвращают, но принимают какие либо аргументы)
void method2(string msg)
{
    Console.WriteLine(msg);
}
method2("Текст сообщения...");*/

/*
void method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; 
    }
}
//method21("Текст сообщения", 3);
method21(count: 4, msg: "Текст сообщения");*/


//Вид 3(метод который, что то возвращает, но ничего не принимает)
/*
int method3()
{
    return DateTime.Now.Year;
}
int year = method3();
Console.WriteLine(year);
*/

//Вид 4(методы которые, что-то принимают и что-то возвращают)

/*
string method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = method4(10, "qwerty");
Console.WriteLine(res); */

/*
string method4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = method4(10, "qwerty");
Console.WriteLine(res); */

/*
for(int i = 2; i <= 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
} */

string text = "-Я думаю, - сказал князь, улыбнувшись, - что, "
            + "ужули бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прессского короля."
            + "Вы так красноречивы. Вы дадите мне чаю? ";
// string s = "qwerty"
//             012345
// s[3] // r, s[0] // q


/*
string Replace(string text, char oldValue, char newValue)
//char old, char new конкретный символ в тексте, конкретный символ новый в замен старому
{
    string result = String.Empty;
    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ',  '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText); */


/*
int [] arr = {1, 5, 4, 7, 8, 3, 2, 6};

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
}
//PrintArray(arr);

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minpos = i;

        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minpos]) minpos = j;
        }
        int temp = array[i];
        array[i] = array[minpos];
        array[minpos] = temp;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr); */

//Перевернуть массив, с самого большого к малому
/*
int [] arr = {1, 5, 4, 7, 8, 3, 2, 6};

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int maxpos = i;

        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxpos]) maxpos = j;
        }
        int temp = array[i];
        array[i] = array[maxpos];
        array[maxpos] = temp;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);*/

Console.Write("Введите ряд чисел, разделенных запятой : ");
string? seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ",";    // дополнительня запятая для обозначения конца строки

// функция удаления пробелов из строки 
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

//  функция  проверки на правильность ввода 
void СheckNumber2 (int  series){

      if (series == '0'||series == '1'||series == '2'
      ||series == '3'||series == '4'||series == '5'||series == '6'
      ||series == '7'||series == '8'||series == '9'||series == ','
      ||series == '-')
      {
      }
        else {
          Console.WriteLine($"Ошибка ввода  символа. Вводи цифры.");

      }
}

// функция  создания и заполнения массива из строки
int[] ArrayOfNumbers(string seriesNew){ 

  int[] arrayOfNumbers = new int[1];    // инициализация массива из 1 элемента

  int j = 0;

  for (int i = 0; i < seriesNew.Length; i++){
    string seriesNew1 = "";

    while (seriesNew[i] != ',' && i < seriesNew.Length){
      seriesNew1 += seriesNew[i];
      СheckNumber2(seriesNew[i]);
      i++;
    }
    arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    // заполняет массив значениями из строки
    if (i < seriesNew.Length-1){
      arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();    // добавляет новый нулевой элемент в конец массива
    }
    j++;
  }
  return arrayOfNumbers;
}

// функция  вывода массива на печать 
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