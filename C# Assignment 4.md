1. Describe the problem generics address.  
Generic allows you to use a class or method that can work with any data type.  

2. How would you create a list of strings, using the generic List class?  
List (Generic): List<T>

3. How many generic type parameters does the Dictionary class have?   
Dictionary<TKey,TValue> generic type has two type parameters, TKey and TValue , that represent the types of its keys and values.

4. True/False. When a generic class has multiple type parameters, they must all match.  True
 
5. What method is used to add items to a List object?  
List.Add() method adds an object to the end of the List<T>. List.AddRange() method adds a collection of objects to the end of the List<T>.
  
6. Name two methods that cause items to be removed from a List.  
  Remove() and List.RemoveAt() methods with List.Clear() method can be used to remove items of a List<T> in C#.
  
7. How do you indicate that a class has a generic type parameter?  
  A generic type is declared by specifying a type parameter in an angle brackets after a type name, e.g. TypeName<T> where T is a type parameter.
  
8.True/False. Generic classes can only have one generic type parameter. False  
  
9.True/False. Generic type constraints limit what can be used for the generic type. True
  
10.True/False. Constraints let you use the methods of the thing you are constraining to. True
