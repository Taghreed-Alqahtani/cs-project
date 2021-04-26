> as

1. 'as' is a keyword used for conversion from one type to another. The type can be a reference or nullable.
2. 'as' keyword checks the compatibility of one object type with another object type. In case of compatible, 
it will return the value of the new object type otherwise, null will be returned.
3. If the conversion from one type to another type fails, then it will return a null value instead of raising an exception. 
So, the return value can be null also.
4. We cannot perform conversion of value types (int, double, char, bool) and user-defined types.
5. The return type should be the reference or nullable type. Since the returned value can be null and as we know value types cannot contain null, value types cannot be used.
'as' improves the performance and it is safe for casting.


`` 
using System;

class Dog
{
    public void Speak() { Console.WriteLine("Bark!"); }
}

class Example
{
    static void Main()
    {
        Object obj = new Dog();

        Dog dog = obj as Dog;
        if (dog != null)
            dog.Speak();
    }
}
``