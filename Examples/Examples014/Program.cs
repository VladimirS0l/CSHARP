using System.Linq;

string text = "(1,2) (2,3) (4,5) (9,7)"
                    .Replace("(", "")
                    .Replace(")", ""); //.Replace - заменяет в тексте выбранные символы
Console.WriteLine(text);

var data = text.Split(" ") //.Split - разбивает текст на отдельные строки,
                .Select(item => item.Split(',')) // .Select - делает выборку 
                //разбивает каждую строку на элементы. Например: 1,2 => 1 2
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1]))) //.Parse - переводим из текст в числа
                .Where(e => e.x % 2 == 0) // .Where - дает возможность установить условие
                .Select(point => (point.x * 2, point.y * 2))
                .ToArray(); // ToArray - переводит текст в формат массива


for(int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
}
