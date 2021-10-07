# Lecture 3 exercises
## Exercise 1
Explain, in your own words, the access modifiers: private, protected, and public. When would you use each? Which would you use by default? 

**1a)** Replace the modifier placeholders with the most restrictive access modifier possible. 
```C#
abstract class Vehicle 
{	
	[modifier] static int _lastID;
	
	[modifier] Vehicle() 
	{
		ID = _lastID++;
	}
	
	[modifier] int ID { get; }
	[modifier] double FuelLevel { get; [modifier] set; }
	
	[modifier] abstract void Refill(double amount);
}
class Car : Vehicle {
	[modifier] double _maxFuelLevel;
	
	[modifier] Car(double maxFuelLevel) : base() 
	{
		_maxFuelLevel = maxFuelLevel;
	}
	
	[modifier] override void Refill(double amount) 
	{
		if (FuelLevel + amount <= _maxFuelLevel)
			FuelLevel += amount;
		else FuelLevel = _maxFuelLevel;
	}
}
class Program {
	public static void Main()
	{
		Car car = new Car(35.00); 
		Car car = new Car(35.00);
            Console.Write($"Refueling car with ID {car.ID} from fuel level {car.FuelLevel}");
            car.Refill(50);
            Console.WriteLine($" to fuel level {car.FuelLevel}");
	}
}
```

Note: [string interpolation in C#](https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/string-interpolation)


## Exercise 2
Create the classes Employee, Manager, and Company 

**2A)** Add the properties Name, Title, MonthlySalary, Seniority to Employee, add initial values and add validation. *Hint: decimal struct*.
```
Initial values: 
- Name should be initialised as “Unknown” (if invalid value is given on construction)
- Title should be initialised as “Unknown”
- MonthlySalary should be initialised as 0
- Seniority should be initialised as 1

Validation criteria: 
- Name is read-only (and assigned on construction)
- Name & Title cannot be null 
- Name & Title cannot be empty 
- MonthlySalary is appropriate for financial calculations
- MonthlySalary cannot be negative 
- Seniority (level) is within the range 1 - 10 

Do not change property value if criteria are not fulfilled 
```

**2B)** Implement a method CalculateYearlySalary to Employee, which follows the algorithm below. 
```
Algorithm: 
- Add together the monthly salary for 12 months
- Add seniority-based extra pay
  - 10% for levels 1 - 2
  - 30% for levels 3 - 6
  - 70% for levels 7 - 10
```

**2C)** Make Manager a subclass of Employee, add the property Bonus, and its validation.
```
Validation criteria:
- Bonus is appropriate for financial calculations
- Bonus cannot be negative 

Do not change property value if criteria are not fulfilled 
```

**2D)** Implement a specialized version of the method CalculateYearlySalary to Employee, which follows the algorithm below.
```
Algorithm: 
- Add together the monthly salary for 12 months
- Add seniority-based extra pay
  - 10% for levels 1 - 2
  - 30% for levels 3 - 6
  - 70% for levels 7 - 10
- Add Bonus 
```

**2E)** Add the methods Hire and Fire to Company, which add/remove employees and managers to/from an internal list of employees.

**2F)** Add the method CalculateYearlySalaryCosts to Company, which adds together all the employees’ salaries.

## Exercise 3
A Point class has been provided, but create the classes Figure, Circle, Rectangle classes
```C#
public class Point 
{
	public Point(double x, double y) 
	{
		X = x;
		Y = y;
	}
	public double X { get; }
	public double Y { get; }
}
```

**3A)** Make it impossible to instantiate a Figure object and add the methods below without any implementation.
```
Methods: 
- CalculateArea()
  - calculates the area of the figure
- ContainsPoint(Point p)
  - takes point and returns whether a point is within the figure
  - takes null and returns false
```

**3B)** Make Circle and Rectangle subtypes of Figure. 

**3C)** Add the properties Center and Radius to Circle, add initial values and add validation.
```
Initial values: 
- Center should initialise as a non-null value
- Radius should initialise as a positive value

Validation criteria: 
- Center and Radius are read-only (and assigned on construction)
- Center cannot be null
- Radius cannot be negative

Do not change property value if criteria are not fulfilled 
```

**3D)** Add the properties P1 and P2 to Rectangle, add initial values and add validation.
```
Initial values: 
- P1 should initialize as a non-null value
- P2 should initialize as a non-null value

Validation criteria: 
- P1 cannot be null
- P2 cannot be null

Do not change property value if criteria are not fulfilled
```

**3E)** Implement CalculateArea and Contains for the classes Circle and Rectangle

## Exercise 4
Lookup the Object.ToString method.

**4A)** Explain why the object produces the following output. 
```C#
Employee employee = new Employee("Joe") { JobTitle = "Programmer" };
Console.WriteLine(employee); // Employee
```

**4B)** Implement a specialized version of the method ToString in Employee, which produces the string as below. 
```C#
"Employee Joe Stevens (Programmer)"
```

**4C)** Implement a specialized version of the method ToString in Employee, which produces the string as below. 
```C#
"Manager Mary Stevens (Software Engineer)"
```

# Rehearsal of lecture 2
Create a class BankAccount class

## Exercise 5
**5A)** Add the properties Balance, BorrowingRate, SavingsRate to BankAccount, add initial values and add validation. Balance should be readonly.
```
Initial values: 
- Balance should be initialized as 0
- BorrowingRate should be initialized as 0.06
- SavingsRate should be initialized as 0.02

Validation criteria: 
- Balance, BorrowingRate and SavingsRate must be appropriate for financial calculations 
- Balance must never be less than -100 000
- Balance must never be more than 250 000
- BorrowingRate must be at least 6%
SavingsRate must be below 2%

Do not change property value if criteria are not fulfilled 
```

**5B)** Implement the methods Deposit and Withdraw, which modifies the balance by an amount. Ignore deposit or withdrawal if the amount is negative. 

**5C)** Implement the method AccrueOrChargeInterest, which adds savings interest to the balance if balance is positive or subtracts borrowing interests if balance is negative. 

# Exercise 6
An empty FileExplorer class has been provided. 

**6A)** Implement PrintDirectory, which takes DirectoryInfo and prints as below. *Hint: tab character.*
```
Directory of C:\Users\Admin\Desktop

04 Mar 2020 08.16	  <DIR>	subdirectory 1
05 Mar 2020 09.23	  <DIR>	subdirectory 2
03 Mar 2020 17.34	  34.05kb	file4.txt	
```

**6B)** Implement PrintTree, so that only the first parameter is required. Hint: Recursion depth & Overloading 
```
C:\Users\Admin\Desktop
|---subdirectory 1
|   |---file1.txt
|   |---file2.txt
|---subdictory 2
|   |---file3.txt
|---file4.text 
```

