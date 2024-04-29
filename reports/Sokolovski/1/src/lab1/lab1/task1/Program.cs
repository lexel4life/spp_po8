int n = args.Length;
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(args[i]);
}
Array.Sort(arr);
if (n % 2 != 0)
{
    Console.WriteLine(arr[(n-1)/2]);
}
else
{
    Console.WriteLine((double)(arr[n/2]+arr[n/2-1])/2);
}