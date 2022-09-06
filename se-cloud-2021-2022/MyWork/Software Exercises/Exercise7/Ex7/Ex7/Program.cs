// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Microsoft.Extensions.Configuration;
using Ex7;

Console.WriteLine("Hello, World!");
Console.WriteLine("Reading configuration sample!");
//Console.ReadLine();



var builder = new ConfigurationBuilder()

// Fluent API

.SetBasePath(Directory.GetCurrentDirectory())
.AddJsonFile("appsetting.json", optional: false, reloadOnChange: true);
//.AddCommandLine(args)
//.AddEnvironmentVariables();

var configuration = builder.Build();

// read single variable
var settingss = configuration["one"];
Console.WriteLine($"Value of variable one: {settingss}");

// read a section
var section = configuration.GetSection("Settings");
var number = section["number"];
var word = section["wordd"];

var nested = section.GetSection("nested");
var nestedVar = nested["nestedVar"];

Console.WriteLine($"nestedVar in {nested} : {nestedVar}");
Console.WriteLine($"wordd in Settings {word}");
Console.WriteLine($"number in Settings {number}");

// Class binding using json and Bind()
ClassToBind classToBind = new ClassToBind();

configuration.GetSection("BindClass").Bind(classToBind);

Console.WriteLine($"Variables from classToBind read from json {classToBind.varOne} + {classToBind.varTwo} + {classToBind.varThree} ");


