// Delete from end of Array

int[] lays = new int[9];

int length = 0;

for(int i = 0; i < 7; i++)
{
    lays[length] = i;
    length++;
}

//length--;


// Delete from beginning of Array

//for(int i = 1; i < length; i++)
//{
//    lays[i - 1] = lays[i];
//}

//length--;


// Delete from Anywhere in Array

for(int i = 3; i < length; i++)
{
    lays[i - 1] = lays[i];
}

length--;



for(int i = 0; i < length; i++)
{
    Console.WriteLine(lays[i]);
}