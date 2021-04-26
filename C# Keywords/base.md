> base

The 'base' keyword is used to access members of the base class from within a derived class:

1. Call a method on the base class that has been overridden by another method.

2. Specify which base-class constructor should be called when creating instances of the derived class.

3. We can't use base class inside a static method.

A base class access is permitted only in a constructor, an instance method, or an instance property accessor.

`` 
sing System;  
public class Animal
{  
    public string color = "white";  
}  
public class Dog: Animal  
{  
    string color = "black";  
    public void showColor()  
    {  
        Console.WriteLine(base.color);  
        Console.WriteLine(color);  
    }  
      
}  
public class TestBase  
{  
    public static void Main()  
    {  
        Dog d = new Dog();  
        d.showColor();  
    }  
} 

``