//Вычислить a^n

int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

//Рекурсия
int PowerRec(int a, int n)
{
    //return n == 0 ? 1 : PowerRec(a, n - 1) * a;
    if(n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}

//Улучшенный подход
int PowerRecMath(int a, int n)
{
    if(n == 0) return 1;
    else if(n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}

Console.WriteLine(PowerFor(2, 10));
Console.WriteLine(PowerRec(2, 10));
Console.WriteLine(PowerRecMath(2, 10));

//сумма чисел от 1 до n
// int SumFor(int n)
// {
//     int result = 0;
//     if(n == 0) return 0;
//     for (int i = 1; i <= n; i++) result += i;
//     return result;
// }

// int SumRec(int n)
// {
//     if(n == 0) return 0;
//     else return n + SumRec(n-1);
// }
// Console.WriteLine(SumFor(10));
// Console.WriteLine(SumRec(10));

//Factorial N

// int FactorialN(int n)
// {
//     int result = 1;
//     if(n == 0) return 1;
//     for (int i = 1; i <= n; i++) result *= i;
//     return result;
// }

// int FactorialRecN(int n)
// {
//     if(n == 0) return 1;
//     else return n * FactorialRecN(n - 1);
// }
// Console.WriteLine(FactorialN(10));
// Console.WriteLine(FactorialRecN(10));

//Вычислить a^n

// int An(int a, int n)
// {
//     int result = a;
//     if(n == 0) return 1;
//     for (int i = 1; i < n; i++) result *= a; 
//     return result; 
// }

// int AnRec(int a, int n)
// {
//     if(n == 0) return 1;
//     else return AnRec(a, n - 1) * a;
// }

// int AnRecMath(int a, int n)
// {
//     if(n == 0) return 1;
//     else if (n % 2 == 0) return AnRecMath(a * a, n / 2);
//     else return AnRecMath(a, n - 1) * a;
// }

// Console.WriteLine(An(2, 10));
// Console.WriteLine(AnRec(2, 10));
// Console.WriteLine(AnRecMath(2, 10));


//Перебор всех возможных вариантов сложения слов
// char[] s = {'a', 'i', 'c', 'v'};
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//     for (int j = 0; j < count; j++)
//     {   
//         for (int k = 0; k < count; k++)
//         {
//             for (int l = 0; l < count; l++)
//             {
//                 Console.WriteLine($"{n++, -5}{s[i]}{s[j]}{s[k]}{s[l]}");
//             }
//         }
//     }
// }
//Общий вариант
// int n = 1;
// void FindWords(string alphabet, char[] word, int length = 0)
// {

//     if(length == word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); return;
//     }
//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         FindWords(alphabet, word, length + 1); 
//     }
// }
// FindWords("aicv", new char[2]);


//Поиск нужных папок в папке
// string path = "C:\\Users\\Yunost\\Desktop\\Работа";
// DirectoryInfo di = new DirectoryInfo(path);
// Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//     Console.WriteLine(fi[i].Name);    
// }

// void CatalogInfo(string path, string indent = "")
// {
//     DirectoryInfo catalog = new DirectoryInfo(path);
//     DirectoryInfo[] catalogs = catalog.GetDirectories();
//     for (int i = 0; i < catalogs.Length; i++)
//     {
//         Console.WriteLine($"{indent}{catalogs[i].Name}");
//         CatalogInfo(catalogs[i].FullName, indent + " ");
//     }
//     FileInfo[] files = catalog.GetFiles();
//     for (int i = 0; i < files.Length; i++)
//     {
//         Console.WriteLine($"{indent}{files[i].Name}");
//     }
// }
// string path = "C:\\Users\\Yunost\\Desktop\\Работа";
// CatalogInfo(path);

//Игра в пирамидки 
// void Towers(string with = "1",
//                 string on = "3",
//                 string some = "2",
//                 int count = 4)
// {
//     if (count > 1) Towers(with, some, on, count - 1);
//     Console.WriteLine($"{with} >> {on}");
//     if (count > 1) Towers(some, on, with, count - 1);
// }
// Towers();

//Решение линейных уровненией с помощью дерева
// string epm = String.Empty;
// string[] tree = {epm, "/", "*", "10", "-", "+", epm, epm, "4", "2", "1", "3"};
// //                  0   1   2     3     4   5     6    7    8   9    10    11    
// void InOrderTraversal(int pos = 1)
// {
//     if (pos < tree.Length)
//     {
//         int left = 2 * pos;
//         int right = 2 * pos + 1;
//         if(left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
//         Console.WriteLine(tree[pos]);
//         if(right < tree.Length &&  !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
//     }
// }
// InOrderTraversal();
