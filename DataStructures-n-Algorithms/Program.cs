//Arrays
//Array Insertions and Deletions Testing My Knowledge

/*
// Insert at the end of Array
int[] veggieRay = new int[10];

int length = 0;

for(int i = 0; i < 7; i++)
{
    veggieRay[length] = i + 1;
    length++;
}

//veggieRay[length] = 12;

// throw away variable to see watch window all the way
//int protein = 0;



// Insert at the beginning of Array

//for (int i = 3; i >= 0; i--)
//{
//    veggieRay[i + 1] = veggieRay[i];
//}

//veggieRay[0] = 88;

//int protein = 0;



// Insert Anywhere in the Array

for (int i = length; i >= 2; i--)
{
    veggieRay[i + 1] = veggieRay[i];
}

veggieRay[2] = 24;

int value = 0;

*/

// challenge with no help ===================

// Insert at the end of Array

int[] arr = new int[10];

int length = 0;

for(int i = 0; i < 8; i++)
{
    arr[length] = i + 1;
    length++;
}

//arr[length] = 13;

//int b = 0;



// Insert at the Beginning of the Array

/*
for(int i = 3; i >= 0; i--)
{
    arr[i + 1] = arr[i];
}

arr[0] = 800;

int value = 0;
*/


// Insert anywhere in the Array

for(int i = length; i >= 4; i--)
{
    arr[i + 1] = arr[i];
}

arr[4] = 24;

int stuff = 0;