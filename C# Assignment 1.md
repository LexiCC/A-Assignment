# 01 Introduction to C# and Data Types
## Understanding Data Types

1. What type would you choose for the following “numbers”? 
  - A person’s telephone number: int
  - A person’s height: double
  - A person’s age: int
  - A person’s gender (Male, Female, Prefer Not To Answer): String
  - A person’s salary A book’s ISBN A book’s price: doule
  - A book’s shipping weight: double
  - A country’s population: int
  - The number of stars in the universe: String
  - The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business) 

2. What are the difference between value type and reference type variables? What is boxing and unboxing?
A Value Type holds the data within its own memory allocation and a Reference Type contains a pointer to another memory location that holds the real data. 
Reference Type variables are stored in the heap while Value Type variables are stored in the stack.

Boxing is the process of converting a value type to the type object or to any interface type implemented by this value type.

3. What is meant by the terms managed resource and unmanaged resource in .NET?
Managed resources are those that are pure . NET code and managed by the runtime and are under its direct control. 
Unmanaged resources are those that are not.

4. Whats the purpose of Garbage Collector in .NET? 
. NET's garbage collector manages the allocation and release of memory for your application.

## Controlling Flow and Converting Types:
1. What happens when you divide an int variable by 0? 
Dividing by zero has no meaning, so undefined.

2. What happens when you divide a double variable by 0? 
It will display Infinity.

3. What happens when you overflow an int variable, that is, set it to a value beyond its range? 
It will throw an OverflowException.

4. What is the difference between x = y++; and x = ++y;? 
 x = y++: x equals to y first, then y plus one;
 x = ++y: y perform plus one first, then x equals to y;

5. What is the difference between break, continue, and return when used inside a loop statement? 
Break: break statement is used to terminate a loop;
Continue: it breaks one iteration (in the loop), if a specified condition occurs, and continues with the next iteration in the loop;
Return: return will exit the current method. 

6. What are the three parts of a for statement and which of them are required? 
The initialization (loop variant), the condition, and the advancement to the next iteration.

7. What is the difference between the = and == operators? 
=: used to assign value to an object or value type
==: is the equality operator it is used to determine if variable is equal to another variable.

8. Does the following statement compile? for ( ; true; ) ; 
No

9. What does the underscore _ represent in a switch expression?
The underscore (_) character replaces the default keyword to signify that it should match anything if reached.

10. What interface must an object implement to be enumerated over by using the foreach statement?
IEnumerable interface

