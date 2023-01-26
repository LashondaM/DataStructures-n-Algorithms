// Linear Search Array

int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//Key means what value are we searching for
bool LinearSearch(int[] array, int key)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == key)
        {
            return true;
        }
    }
    return false;
}

Console.WriteLine(LinearSearch(array, 4));