//4. В прямоугольной матрице найти строку с наименьшей суммой элементов.

// Вариант 1

int [,] myArray = 
{
    {11,14,8,2,3},
    {5,9,2,1,7},
    {5,5,13,0,10},
    {0,9,4,1,17},
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

int sum = 0;
int count = 1;
int lineNumber = 1;
int rowSum = 0;

for (int i = 0; i <  myArray.GetLength(0); i++) 
{    
    sum = 0;
    
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        sum += myArray [i,j];
        
           
    }Console.WriteLine($"Сумма элементов {count} строки равна {sum} ");
    count++;
        
    if (i == 0 && rowSum < sum) // i == 0 если строка первая 
    {
        rowSum = sum;
    }
    else if (rowSum > sum)
    {
        rowSum = sum;
        lineNumber += i; 
    }
                
  
}Console.WriteLine($"Наименьшая сумма {rowSum} в {lineNumber} строке");




// Вариант 2

/*Console.WriteLine("Введите количество строк Вашего массива: ");
int numberOfRows = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите количество столбцов Вашего массива: ");
int numberOfColumns = int.Parse(Console.ReadLine()?? "0");

if (numberOfRows != numberOfColumns)
{
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

    int sum = 0;
    int count = 1;
    int lineNumber = 1;
    int rowSum = 0;

    for (int i = 0; i <  myFilledArray.GetLength(0); i++) 
    {    
        sum = 0;
    
        for (int j = 0; j < myFilledArray.GetLength(1); j++)
        {
            sum += myFilledArray[i,j];
        
           
        }Console.WriteLine($"Сумма элементов {count} строки равна {sum} ");
        count++;
        
        if (i == 0 && rowSum < sum) // i == 0  мы на первой строке
        {
            rowSum = sum;
        }
        else if (rowSum > sum)
        {
            rowSum = sum;
            lineNumber += i; 
        }
                
  
    } Console.WriteLine($"Наименьшая сумма {rowSum} в { lineNumber} строке");

}
else 
Console.WriteLine($"Массив не прямоугольный!!!");*/











          
