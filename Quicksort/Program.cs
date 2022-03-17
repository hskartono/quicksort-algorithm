void swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

int partition(ref int[] arr, int low, int high)
{
    int pivot = arr[high];
    int i = (low - 1);
    for(int j= low; j <= high; j++)
    {
        if(arr[j] < pivot)
        {
            i++;
            swap(ref arr[i], ref arr[j]);
        }
    }
    swap(ref arr[i + 1], ref arr[high]);
    return i + 1;
}

void quicksort(int[] arr, int low, int high)
{
    if(low < high)
    {
        int pi = partition(ref arr, low, high);
        quicksort(arr, low, pi - 1);
        quicksort(arr, pi + 1, high);
    }
}

void ShowData(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

// data preparation
int[] arrdata = { 10, 80, 30, 90, 40, 50, 70 };

Console.WriteLine("Unsorted data:");
ShowData(arrdata);

// start sorting
quicksort(arrdata, 0, arrdata.Length - 1);

// write result
Console.WriteLine("Sorted data:");
ShowData(arrdata);