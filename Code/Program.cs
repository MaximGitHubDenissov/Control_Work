Console.WriteLine("Введите данные (символы, буквы или числа) через запятую, без пробелов после запятой");
string[] array = (Console.ReadLine()!.Split(','));
string[] result = new string[array.Length];
for (int i = 0; i < array.Length; i++){
    if (array[i].Length <= 3)result[i] = array[i];}        
result = result.Where(x => !string.IsNullOrEmpty(x)).ToArray(); // Убирает пустые строки из массива
Console.WriteLine("[" + String.Join(",", array) + "]" + " ==> " + "[" + String.Join(",", result) + "]");
