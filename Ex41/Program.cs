// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4


Console.WriteLine("Введите число элементов массива ");
int arr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите элементы массива ");
string num;
int [] array = new int [arr];
int i = 0;
int count = 0;

while ((num = Console.ReadLine()) != "end")
{
    array [i] = Convert.ToInt32(num);
    i++; 
    if (i >= arr)
    {
        break;
    }
}
 for (int j = 0; j < i; j++)
    {
        Console.Write(array[j] + ", ");     
    
    if (array[j] > 0 )
        {
            count++;
        }
    } 
Console.WriteLine();
Console.WriteLine("Больше нуля ->" + count);
    
        
    


