# FakerLib.Net
This is the official repository of the FakerLib.Net dummy data generator library for .NET

### What is FakerLib.Net?
FakerLib.Net is a simple .NET Core package that can be used to create dummy (fake)
list of collections. That is, populate any type of collections (List) (Enumerables) with random data of different sorts : Name, Cities, Phonenumbers, Countries, ZipCodes, UUIDs, Addresses, IPAddresses, URLs, Websites, EmailAddresses, ImageURLs etc. It could be used to populate DB's, collections and so on during development and testing.

### Where can I get it?

First, [install NuGet](http://docs.nuget.org/docs/start-here/installing-nuget). Then, install [FakerLib.Net](https://www.nuget.org/packages/FakerLib.Net/) from the package manager console:

```
PM> Install-Package FakerLib.Net
```
Or from the .NET CLI as:
```
dotnet add package FakerLib.Net
```

### How do I get started?

First, configure FakerLib.Net FakerFactory to let it know what properties of a type (e.g class) do want to generate fake/dummy for by annotating each property of choice by a FakeAttribute like below:
For instance, for a model class of Person, you would configure like below:

```csharp
public class Person
{
        [Fake(FakerType.Name)]
        public string Name { get; set; }
        [Fake(FakerType.City)]
        public string City { get; set; }
        [Fake(FakerType.Phone)]
        public string Phone { get; set; }
        public string HouseAddress { get; set; } = string.Empty;
}

```
Then anywhere in your application code where you need a list of type(Person) filled with dummy data, use below.

```csharp
var fakerFactory = new FakerFactory();
var dummyListOfPersons = fakerFactory.Setup<Person>(typeof(Person), 5) //meaning to generate 5 items of this type(Person) of dummy data.

```

OR you can use Dependency Injection by registering FakerFactory in your startup.cs DI container like below 

```csharp
//For .NET 6 and above
builder.Services.AddFakerFactory();

//For .NET 5 and below
services.AddFakerFactory();

//then you can inject typeof(IFakerFactory) into any class's constructor and make use of it. 
private readonly IFakerFactory _fakerFactory;
public PersonService(IFakerFactory fakerFactory)
{
_fakerFactory = fakerFactory;
}

//Then make use of it somewhere inside this service class like below.
var dummyListOfPersons = _fakerFactory.Setup<Person>(typeof(Person), 5) //meaning to generate 5 items of this type(Person) of dummy data.


```




