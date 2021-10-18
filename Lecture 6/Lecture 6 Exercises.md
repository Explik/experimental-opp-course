# Lecture 6 exercises

## Exercise 1

A simple temperature class has been provided. 
```C#
class Temperature 
{
    double _value;
}
```

**1A)**  Add the properties Celsius, Fahrenheit, Kelvin, which all use in _value as storage, and add validation. 
```
Validation criteria: 
- The temperature must not be less than absolute zero, i.e. Kelvin value cannot be negative.

Throw ArgumentException if the criterion is not fulfilled.
```

**1B)** Implement the IComparable interface on Temperature, which satisfies the requirements below. 
```
CompareTo requirements: 
- Null precedes any temperature instances.
- Colder temperatures precede hotter temperatures.
```

## Exercise 2

Create the classes Car, CarPriceComparer and CarMakeModelPriceComparer.

**2A)** Add the properties ID, Make, Model and Price to Car and add validation.
```
Validation criteria: 
- ID cannot be negative.
- Price cannot be negative. 

Throw ArgumentException or ArgumentNullException if criteria are not fulfilled. 
```

**2B)** Implement the interface IComparable on Car to sort the cars by ID. Additionally, nulls must always precede any cars.  

**2C)** Implement the interface IComparer<Car> on CarPriceComparer to sort the cars by price. Additionally, nulls must always precede cars.

**2D)** Implement the interface IComparer<Car> on CarMakeModelPriceComparer to sort the cars by make, then by model, then by price. Additionally, nulls must always precedes any car instances.
 
## Exercise 3

Create interface IRandom, and the classes MyRandom, PredictablyRandom and Die.

**3A)** Define the methods int Next(), int Next(int max), int Next(int min, int max) in IRandom. 
  
**3B)** Implement the interface IRandom on MyRandom to generate random numbers. *Hint: System.Random.*
  
**3C)** Implement the interface IRandom on PredictableRandom, and add a constructor that takes an integer that Next returns every time. Add validation in PredictableRandom.Next, which checks if the injected value is within the range [min, max] else throw an ArgumentException.
  
## Exercise 4
  
Explain, in your own words, dependency injection through constructors.
  
**4A)** Create a class Die, and add a constructor to Die, which injects an IRandom object. 
  
**4B)** Add an additional constructor, which also specifies the number of sides.
  
**4C)** Add the method Roll, which returns a number between 1 and the number of sides.
  
## Exercise 5

Explain, in your own words, dependency injection through properties.
  
**5A)** Create a class CarSorter, and add a property Comparer, which injects an IComparer<Car> object for sorting.
  
**5B)** Add a method Sort, which sorts a list with the Comparer. If the Comparer is null, the list should be left unchanged.
  
# Rehearsal of Lecture 4

## Exercise 6
    
Explain why it could be beneficial to add a logger interface as opposed to writing directly to file or console.
  
**6A)** Create an interface with a void method Log(string message) to ILogger.
  
**6B)**  Add a constructor(string path) to FileLogger, which opens a stream to the file on the path.
  
**6C)**  Implement ILogger in FileLogger, so that it writes the messages to file.
  
**6D)** Implement the IDisposable interface on FileLogger to dispose of the stream. *Hint: unmanaged resources.*
  
**6E)** Implement the ILogger on FileLogger to append log messages to the file.

log.txt before FileLogger.Log(“Customer Ryan Johnson was deleted”)
```
Customer Ryan Johnson was created
```

log.txt after FileLogger.Log(“Customer Ryan Johnson was deleted”)
```
Customer Ryan Johnson was created
Customer Ryan Johnson was deleted
```
  
**6F)**  Implement the ILogger on ConsoleLogger, and print messages to console.

Console output after ConsoleLogger.Log(“Customer Ryan Johnson was deleted”)
```
Customer Ryan Johnson was created
```  

## Exercise 7 

Explain why to create a TextFile class.
  
**7A)** Implement the constructor TextFile(string path), which opens a stream to the file.
  
**7B)** Add a read-only property Content, which returns the content of the file. 
  
**7C)** Implement the IDisposable interface on TextFile to dispose of the stream. Content should be null after disposal. *Hint: unmanaged resources.*
