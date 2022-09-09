// Loops 
// For Loop, While Loop, Foreach Loop, Do While Loop
// Variants of our two main types of loops: For loop, While Loop
// Loop is a block of code that repeats.

// For Loop! 
// The most common type of loop. 
// For loop is a block of code that runs a certain number of times. Or, a block of code that repeats for some range of numbers.
// for( initializer; condition; increment){
//  code to run
// }
// initializer -> statement that runs before the for loop starts
// condition -> condition we check after each loop to see if we should keep running
// increment -> statement we run after the each loop ends.

// While Loop!
// Simplest loop. 
// Runs WHILE a condition is true.
// while(condition){
//  code to run
//  include either a change to the condition OR a break statement
// }

// For Each Loop!
// Specific version of the for loop that repeats FOR EACH item in some collection
// Example. For each loop on a bag of 5 things will run 5 times. Add something to the bag, and it would run 6 times.

// Do While Loop!
// A do while loop is just a while loop that is guaranteed to run once.
// do {
//  code to run
// }
// while(condition);

// Let's say we want to print out every number 0 to 100.
// FOR:
for (var i = 0; i <= 100; i++)
{
    Console.WriteLine(i);
    if (i == 47)
    {
        break;
    }
}
// break takes us here

var j = 0;
while(j <= 100)
{
    j++;
    Console.WriteLine(j);
    if (j == 47)
    {
        break;
    }
}

var k = 250;
do
{
    k++;
    Console.WriteLine(k);
}
while(k <= 100);