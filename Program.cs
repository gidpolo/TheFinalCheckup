string UserRead()
{
    string N = Console.ReadLine() ?? "";
    return N;
}

string[] FillArray(int size)
{
    string[] arr = new string[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Write {i} element: ");
        arr[i] = UserRead();
    }

    return arr;
}

int Count(string[] arr)
{
    int count = 0;
    foreach (string str in arr)
    {
        if (str.Length <= 3)
        {
            count++;
        }
    }

    return count;
}

string[] CopyCount(string[] initialArr)
{
    int copySize = Count(initialArr);
    string[] newArr = new string[copySize];

    int count = 0;
    foreach (string str in initialArr)
    {
        if (str.Length <= 3)
        {
            newArr[count++] = str;
        }
    }

    return newArr;
}

void ShowArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

Console.WriteLine("Size of array: ");
int size = Int32.Parse(UserRead());
string[] arr = FillArray(size);
string[] duplicate = CopyCount(arr);
ShowArr(duplicate);