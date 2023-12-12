// Задача 3: Задайте массив из вещественных чисел с
// ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементом массива. 


Console.WriteLine("Введите размер массива");
int num = Convert.ToInt32(Console.ReadLine());

double[] array = new double[num];
Random rand = new Random();
for ( int i = 0; i < array.Length; i++)
{
    array[i] = rand.NextDouble()*100;
    Console.Write(array[i] + " ");
}
    double max = array[0];
    double min = array[0];
for (int i = 0; i < array.Length; i++)
{  
    
    if (array[i] > max)
    {
        max = array[i]; 
    }  
    if (array[i] < min)
    {
        min = array[i];
    }
}
    Console.WriteLine();
    Console.WriteLine(max - min);