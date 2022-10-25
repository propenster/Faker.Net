// See https://aka.ms/new-console-template for more information
using Faker.Net;
using FakerTester;

Console.WriteLine("Hello, World!");

var faker = new FakerFactory();

var setList = faker.Setup<MyClass>(typeof(MyClass), 5);

var countList = setList.Count();
Console.WriteLine($"The List has been faked ... We have {countList} items");

