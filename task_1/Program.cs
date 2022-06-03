// 1.Написать программу, которая обменивает элементы первой строки и последней строки.

// Вариант 1

int [,] myArray = 
{
    {4,6,8,2,3},
    {5,9,2,1,7},
    {8,5,3,8,3},
    {2,9,4,1,7},
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
for (int j = 0; j < myArray.GetLength(1); j++) 
{
    temporary = myArray[0, j];
    myArray[0, j] = myArray[myArray.GetLength(0) - 1, j]; 
    myArray[myArray.GetLength(0) - 1, j] = temporary; 
}

Console.WriteLine("Так выглядит Ваш массив после того, как в нем обменяли элементы первой строки и последней строки: ");
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
        Console.Write(myArray[i,j]);
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
for (int j = 0; j < numberOfColumns; j++) // numberOfColumns = myFilledArray.GetLength(1)
{
    temporary = myFilledArray[0, j];
    myFilledArray[0, j] = myFilledArray[numberOfRows - 1, j]; // numberOfRows = myFilledArray.GetLength(0)
    myFilledArray[numberOfRows - 1, j] = temporary; // numberOfRows = myFilledArray.GetLength(0)
}

Console.WriteLine("Так выглядит Ваш массив после того, как в нем обменяли элементы первой строки и последней строки: ");
for (int i = 0; i < myFilledArray.GetLength(0); i++)
{
    for (int j = 0; j < myFilledArray.GetLength(1); j++)
    {
        Console.Write($"{myFilledArray[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();*/





