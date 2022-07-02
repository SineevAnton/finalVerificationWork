# finalVerificationWork
This work is necessary to test knowledge and skills as a result of completing the first block of training under the developer program.

### Task.
___
Write a programm, which will create an array of string from an initial array, using only string with length less or equal 3. You can type initial array using keyboard or define it into your code. It's not recomended to use collections, it's better to use only arrays.
___

## No-code solution:

### First way.
Using loop we will check how many elements of the initial array gave length less or equal 3. And place this number into some variable (for example 'answerSize').
Then we will create new array with size equal to 'aswerSize'.
After that using loop againg we will check every element of the initial array and add those elements to the answer array, which length less or equal 3.

### Second way.
We create some empty string variable.
Then check every element of the initial array, if it's length less or equal 3.
Concatenate elements, satisfying this condition, to our string, separetes them using space symbol.
After that using such methods, as Split() and ToArray() we transform our string to the answer array.

### Other methods
There are a lot of other algorithms, to solve our task.
Example: we can create string with indexes of elements of the initial array, that are less or equal 3.
And using this string fill our final array.
But lets stop on previous two ways.