//Arrays
//Array Insertions and Deletions

// Inserting at the end of an Array O(1)

int[] intArray = new int[10];

// Make a variable to keep the length because .Length is based off capacity and does not track the actual index
int length = 0;

//This adds data for us
for (int i = 0; i < 8; i++)
{
    //1 is optional
    intArray[length] = i + 1;
    length++; // iterate so we put values inside the array and keep track of the length
}

/* insertion for the end of the array */
//intArray[length] = 8;
//length++;


/* ============ Inserting at the start of an Array ============ */
/* for (int i = 3; i >= 0; i--)
{
    // this is moving over all the values in the array
    intArray[i + 1] = intArray[i];
}

intArray[0] = 20;

// this is so we can see the 20 get assigned before the Watch window closes
int value = 0;

*/


/* ============ Inserting anywhere in the array ============ */
for (int i = 4; i >= 2; i--)
{
    //Shift each element one position to the right
    intArray[i + 1] = intArray[i];
}

intArray[2] = 8;

int value = 0;