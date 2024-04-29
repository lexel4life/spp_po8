int n = Convert.ToInt32(args[0]);
int m = Convert.ToInt32(args[1]);
double[,] arr = new double[n,m];
int counter = 2;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        arr[i, j] = Convert.ToInt32(args[counter]);
        counter++;
    }
}

double[] result = Flatten(arr);
foreach (var d in result)
{
    Console.Write($"{d} ");
}

double[] Flatten(double[,] array)
{
    int index = 0;
    int n = array.GetLength(0);
    int m = array.GetLength(1);
    double[] newArr = new double[n*m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            newArr[index] = array[i, j];
            index++;
        }
    }

    return newArr;
}