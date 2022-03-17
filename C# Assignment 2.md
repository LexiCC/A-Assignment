## 02  Arrays and Strings
1. When to use String vs. StringBuilder in C# ?
String is immutable, once we create a string we can never change it, StringBuilder is used to represent a mutable string of characters.

2. What is the base class for all arrays in C#?
Array

3. How do you sort an array in C#?
We can use Using Array.Sort() method or CompareTo() method to loop through the array

4. What property of an array object can be used to get the total number of elements in an array?
Length property

5. Can you store multiple data types in System.Array?
No

6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
72

The Clone() method returns a new array (a shallow copy) object containing all the elements in the original array. 
The CopyTo() method copies the elements into another existing array. 
