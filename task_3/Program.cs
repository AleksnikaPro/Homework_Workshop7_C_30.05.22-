//3. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

Console.Clear();
Console.Write("Введите количество строк Вашего массива: ");
int numberOfRows = int.Parse(Console.ReadLine()?? "0");
Console.Write("Введите количество столбцов Вашего массива: ");
int numberOfColumns = int.Parse(Console.ReadLine()?? "0");


int [,] myArray = new int [numberOfRows,numberOfColumns];
for (int i = 0; i < numberOfRows; i++)
{
    for (int j = 0; j < numberOfColumns; j++)
    {        
        Console.Write($"{myArray[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int [,] myFilledArray = new int [numberOfRows,numberOfColumns];
Console.WriteLine("Ваш массив:");
for (int i = 0; i < myFilledArray.GetLength(0); i++)
{
    for (int j = 0; j < myFilledArray.GetLength(1); j++)
    {
        myFilledArray[i,j] = new Random().Next(0,10);
        Console.Write($"{myFilledArray[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int[,] changedArray = new int [myFilledArray.GetLength(0), myFilledArray.GetLength(1)];

if (myFilledArray.GetLength(0) == myFilledArray.GetLength(1))
{   Console.WriteLine("Ваш массив, в котором заменили строки на столбцы:");  
    
    for (int i = 0; i < myFilledArray.GetLength(0); i++) 
    {
        for (int j = 0; j < myFilledArray.GetLength(1); j++)
        {
           changedArray[i, j] = myFilledArray[j, i];
           Console.Write($"{changedArray[i,j]} "); 
        } 
        Console.WriteLine();
    }  

}   
else
{
    Console.WriteLine("Матрица не квадратная! Заменить строки на столбцы невозможно!");
}
Console.WriteLine(); 
