## 03 Object-Oriented Programming

1. What are the six combinations of access modifierkeywords and what do they do?  
- Public: Objects are accessible from everywhere in a project
- Private: Objects are accessible only inside a class or a structure. 
- Protected: Objects are accessible inside the class and in all classes that derive from that class.
- Internal: Objects are limited exclusively to classes defined within the current project assembly.
- Protected Internal: we can access the protected internal member only in the same assembly or in a derived class in other assemblies.
- Private Protected: We can access members inside the containing class or in a class that derives from a containing class, but only in the same assembly(project).

2. What is the difference between the static, const, and readonly keywords when applied to a type member?  
The static keyword is used to make members static that can be shared by all the class objects;  
A const field cannot be modified after declaration, it is a compile-time constant;  
ReadOnly keyword is used to make a field constant which value cannot be modified, readonly fields can be used for run-time constants.  

3. What does a constructor do?  
A constructor is a special method of a class or structure in object-oriented programming that initializes a newly created object of that type.  

4. Why is the partial keyword useful?  
The partial keyword indicates that other parts of the class, struct, or interface can be defined in the namespace.

5. What is a tuple?
A tuple is a data structure that contains a sequence of elements of different data types.  

6. What does the C# record keyword do?  
 Record keyword is used to define a reference type that provides built-in functionality for encapsulating data. 

7. What does overloading and overriding mean?  
- Overriding: happens in run-time, between base class and derived class; same method signature, but derived class have different implementation of method body;   
- Overloading: happens in compile time, multiple methods in the same class, same name, same access modifiers but different input parameters.  

8. What is the difference between a field and a property?  

The real difference is in their intended scope. Fields are meant to be private or protected in scope, meaning that access is restricted.  
Properties are meant to be public in scope, meaning that access is not restricted.

9.  How do you make a method parameter optional?  
- by using default value;  
- by using Method Overloading;   
- by using OptionalAttribute;  

10.What is an interface and how is it different fromabstract class?  
An abstract class permits you to make functionality that subclasses can implement or override whereas an interface only permits you to state functionality but not to implement it.  
A class can extend only one abstract class while a class can implement multiple interfaces.  

11.What accessibility level are members of an interface?  
Interface members implicitly have public declared accessibility. 


12.True/False. Polymorphism allows derived classes to provide different implementations of the same method.  True

13.True/False. The override keyword is used to indicate that a method in a derived class is providing its own implementation of a method.  True  

14.True/False. The new keyword is used to indicatethat a method in a derived class is providing its own implementation of a method.  False  

15.True/False. Abstract methods can be used in a normal (non-abstract) class.  False  

16.True/False. Normal (non-abstract) methods can be used in an abstract class.  True  

17.True/False. Derived classes can override methods that were virtual in the base class.  True  

18.True/False. Derived classes can override methods that were abstract in the base class.  True  

19.True/False. In a derived class, you can override a method that was neither virtual non abstract in the base class.  False  

20.True/False. A class that implements an interface does not have to provide an implementation for all of the members of the interface. False  

21.True/False. A class that implements an interface is allowed to have other members that aren’t defined in the interface.  True  

22.True/False. A class can have more than one base class.  True  

23.True/False. A class can implement more than one interface.  False  
