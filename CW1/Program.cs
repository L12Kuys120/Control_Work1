// Control work
Console.WriteLine("Enter size of array more 2");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Enter array");
string[] array = new string[N];  // Задание массива вручную
for (int i = 0; i < N; i++) array[i] = Convert.ToString(Console.ReadLine());

Console.WriteLine("");

Console.WriteLine("[" + string.Join(" ", array) + "]");  //вывод массива в строку 
Console.WriteLine("");

int P = new Random().Next(0, 3);
string[] arr = new string[P];

for (int i = 0; i < P; i++)
{
    int j = new Random().Next(0, N - 1);
    arr[i] = array[j];           //Выборка Р-элементов
}


Console.WriteLine("[" + string.Join(" ", arr) + "]");
Console.WriteLine("");