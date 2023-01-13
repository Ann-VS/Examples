int[] array = {17, 12, 53, 4, 25, 4, 47, 2};

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
index++;
}
