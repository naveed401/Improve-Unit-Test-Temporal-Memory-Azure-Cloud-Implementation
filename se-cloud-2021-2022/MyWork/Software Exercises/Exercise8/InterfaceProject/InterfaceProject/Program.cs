
// See https://aka.ms/new-console-template for more information
using InterfaceProject;

Class1 cls1 = new Class1();
Class2 cls2 = new Class2();

// calling the implemented function
Console.WriteLine("Class1 implemnetation:");
cls1.ThisHasTobeImplemented();
Console.WriteLine(cls1.ThrowMeANumber(401));

// calling the implemented function
Console.WriteLine("Class2 implemnetation:");
cls2.ThisHasTobeImplemented();
Console.WriteLine(cls2.ThrowMeANumber(401));

Console.WriteLine("Hello, World!");

