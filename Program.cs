/*
    Контрольная работа
*/

string[] createArray(int m)
{
    string[] array = new string[m];
    for(int i = 0; i < m; i++)
    {
        array[i] = "a" + new Random().Next(0, 200);
    }
    return array;
}

void print(string[] arr, int resultSize)
{
    for(int z = 0; z < resultSize; z++)
    {
        Console.Write($" {arr[z]} ");
    }
    Console.WriteLine();
}

int size = 5; 
string[] array = createArray(size);
Console.WriteLine("Первоначальный массив");
print(array, size);
string[] temp = new string[size];

int j=0;
for(int i = 0; i < size; i++ ) 
{

    if( array[i].Length <= 3)
    {
        temp[j] = array[i];
        j++;
    }

}

string[] result = new string[j];

for(int t = 0; t < j; t++)
{
    result[t]=temp[t];
}

Console.WriteLine("Результирующий массив");
print(result, j);

