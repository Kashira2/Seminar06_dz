Console.WriteLine("Введите 5 чисел: ");
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());
int n4= int.Parse(Console.ReadLine());
int n5 = int.Parse(Console.ReadLine());

int[] mas = new int [5];
int Array (int a, int b, int c, int d, int e)
{
    int count = 0;
    int[] array = {a,b,c,d,e};
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine("Из введенных чисел " + Array(n1,n2,n3,n4,n5) + " больше нуля");