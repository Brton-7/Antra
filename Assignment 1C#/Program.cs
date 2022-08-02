//=================ASSIGNMENT 1=================================================
//=================Brandon Tong=================================================

//1.What type would you choose for the following “numbers”?
//A person’s telephone number: string
//A person’s height: string
//A person’s age: int
//A person’s gender (Male, Female, Prefer Not To Answer): enum
//A person’s salary: decimal
//A book’s ISBN: string
//A book’s price: decimal
//A book’s shipping weight: double
//A country’s population: uint
//The number of stars in the universe: uint
//The number of employees in each of the small or medium businesses in the
//United Kingdom (up to about 50,000 employees per business)P: enum

//2.What are the difference between value type and reference type variables? What is
//boxing and unboxing?
//Answer: Value types directly contain data do not affect other operations,
//        are stored in stack memory and can be created by structs or enum.
//
//        Reference type variables store the reference to data (or address)
//        which is stored in heap, can affect other operations can be created
//        by class, interface, delegate, array and unlike value type can accept
//        a null value
//
//        Converting value to reference type is boxing, likewise converting
//        reference type to value is unboxing


//3. What is meant by the terms managed resource and unmanaged resource in .NET
//Answer: A managed resource is anything within the scope of .NET including framework
//        string, int, and bool. An Unmanaged resource are objects created outside of 
//        .NET resources and libraries. These are not managed by Common Language 
//        Runtime and are outside of the control of .NET libraries


//4. Whats the purpose of Garbage Collector in .NET?
//Answer: The Garbage Collector in .NET automatically manages allocation and release
//        of objects in memory.
//
//=====================================================================================
//Controlling Flow and Converting Types
//1. When int variable is divided by 0 program runs ignoring the divide by 0, compile time error
//2. results in positive infinity
//3. The result wraps back to -2147483648
//4. y++ is a post increment that happens after value is assigned, ++y is pre increment that happens before value is assigned
//5. In a loop statement Break will terminates the loop it is in and  and goes on to next statement
//   Continue will start a new iteration of the closes iteration statement it is enclosed in
//   Return wil terminate execution of a function and return result/control to user

//6. Three parts of for statement are initializer to increment from only used in the loop, a condition that
//   decides if another loop is executed, and iterator to progess loop. All three are optional because 
//   all three parts can be defined in the loop

//7. '==' is an equality operator and '=' is used to assign values
//8. 'for( ; true;);' compiles into an infinite loop
//9. In a switch expression the '_' represents a default condition
//10. In order to for an object to be enumerated over with foreach 'IEnumerator' must be used

//int max = 500;
//for (byte i = 0; i<max; i++)
//{
//    Console.WriteLine(i);
//}
//Create a console application and enter the preceding code. Run the console application
//and view the output. What happens?
//What code could you add (don’t change any of the preceding code) to warn us about the
//problem?
//Answer: When the above code runs the application runs in an infinite loop outputting the numbers 1 to 255
//        This error can be handled with an exception that checks the size of data type before input and deny any number too big