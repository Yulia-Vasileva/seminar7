// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


int [,] GetRandomMatrix(int rows, int columns, int LeftRange, int RightRange)
{
    int [,] matrix = new int [rows, columns];

    for (int i=0; i < matrix.GetLength(0); i++)
    {
        for (int j=0; j < matrix.GetLength(1); j++)
        {
            matrix [i,j] = new Random().Next(LeftRange,RightRange + 1);
        }
    }
    return matrix;
}


void PrintMatrix (int [,] matrix)
{
    for (int i=0; i < matrix.GetLength(0); i++)
    {
        for (int j=0; j < matrix.GetLength(1); j++)
        {
            Console.Write (matrix[i, j] + " ");
        }
    Console.WriteLine();
    }
}


int Number(int[,] matrix, int num1, int num2)
{
    int count = 0;

    if(num1<=matrix.GetLength(0) && num2< matrix.GetLength(1))
    {
        count=matrix[num1, num2];
        Console.WriteLine(count);
    }
    else Console.WriteLine("такого числа в массиве нет");
    return count;
}


const int ROWS = 3;
const int COLUMNS = 4;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 10;

int[,] array = GetRandomMatrix (ROWS, COLUMNS, LEFT_RANGE, RIGHT_RANGE);
PrintMatrix(array);

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Number(array, num1, num2);