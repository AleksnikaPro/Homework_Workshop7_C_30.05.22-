// 2. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

// Вариант 1

Console.Clear();
int [,] myArray = 
{
    {1,3,5,2,4},
    {6,8,10,9,11},
    {14,11,13,15,12},
    {18,16,20,19,17},
};
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($"{myArray[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int temporary;
for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        for (int k = 0; k < myArray.GetLength(1) - 1 - j; k++)
        {
            if ( myArray[i, k] < myArray[i, k + 1])
            {
                temporary =  myArray[i, k];
                myArray[i, k] = myArray[i, k + 1];
                myArray[i, k + 1] = temporary;          
            }  
        }         
    } 
}

Console.WriteLine("Так выглядит массив после упорядочивания по убыванию элементов каждой строки:");
Console.WriteLine();
for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        Console.Write($"{myArray[i,j]} ");  
    }
    Console.WriteLine();
}
Console.WriteLine();

// Вариант 2

/*Console.WriteLine("Введите количество строк Вашего массива: ");
int numberOfRows = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите количество столбцов Вашего массива: ");
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

int temporary;
for (int i = 0; i < myFilledArray.GetLength(0); i++)
{
    for (int j = 0; j < myFilledArray.GetLength(1); j++)
    {
        for (int k = 0; k < myFilledArray.GetLength(1) - 1 - j; k++)
        {
            if ( myFilledArray[i, k] < myFilledArray[i, k + 1])
            {
                temporary =  myFilledArray[i, k];
                myFilledArray[i, k] = myFilledArray[i, k + 1];
                myFilledArray[i, k + 1] = temporary;          
            }  
        }         
    } 
}

Console.WriteLine("Так выглядит массив после упорядочивания по убыванию элементов каждой строки:");
Console.WriteLine();
for (int i = 0; i < myFilledArray.GetLength(0); i++) // Выводим отсортированный массив 
{
    for (int j = 0; j < myFilledArray.GetLength(1); j++)
    {
        Console.Write($"{myFilledArray[i,j]} ");  
    }
    Console.WriteLine();
}
 Console.WriteLine();*/




