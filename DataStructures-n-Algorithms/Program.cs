//Arrays
//Array Insertions and Deletions

/* logically these deletions removes the number from the array however it's still saved in the array's memory 
 * since an array is at a fixed length */

// Delete from end of array
int[] intArray = new int[9];

int length = 0;

for(int i = 0; i < 6; i++)
{
    intArray[length] = i;
    length++;
}

//length--; //this is for the end of the array


// Delete from the beginning of the array
/* for(int i = 1; i < length; i++)
{
    //use negative 1 if you want to move the value(s) to the left, positive 1 for to the right
    intArray[i - 1] = intArray[i];
}

length--;
*/


// Deleting from anywhere in array
for(int i = 2; i < length; i++)
{
    intArray[i - 1] = intArray[i];
}

length--;


//this is to view the output for all of the loops
for (int i = 0; i < length; i++)
{
    Console.WriteLine(intArray[i]);
}