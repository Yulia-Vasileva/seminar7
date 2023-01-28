// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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


double[] SrArefMatrix (int[,] matrix)
{
    double[] newarray = new double[matrix.GetLength(1)];
 
    for (int j = 0; j < matrix.GetLength(1); j++)
{   
    for (int i = 0; i < matrix.GetLength(0); i++)
    
        newarray[j] = newarray[j] + matrix[i, j];
    
           newarray[j] = newarray[j] / matrix.GetLength(0);
}
return newarray;
}


void Print (double [] newarray)
{
    for (int i=0; i < newarray.Length; i++)
    {        
            Console.Write ($"{newarray[i]:f2}  ");
        
    }
}

const int ROWS = 3;
const int COLUMNS = 4;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 10;

int[,] array = GetRandomMatrix (ROWS, COLUMNS, LEFT_RANGE, RIGHT_RANGE);
PrintMatrix(array);
double[] result = SrArefMatrix (array);
Print(result);

