# Lecture 4 exercises

## Exercise 1
**1A)** Enclose the code below within an appropriate try-catch block.
```C#
Person p;
Console.WriteLine("Welcome " + p.Name);
```

**1B)** Enclose the code below within an appropriate try-catch block.
```C#
string command =  "print".Split(" ");
if (command[0] == "print")
  Console.WriteLine(command[1]);
```

**1C)** Enclose the code below within an appropriate try-catch block.
```C#
int code = (int)"a"; 
```

**1D)** Enclose the code below within an appropriate try-catch block.
```C#
FileStream fileStream = new FileStream(@"C:\Users\Admin\Desktop\f.txt");
```
*Note: [@-symbol in C#](https://stackoverflow.com/questions/556133/whats-the-in-front-of-a-string-in-c)*

## Exercise 2
Create a class Person.

**2A** Add the properties Name, Height, and Weight to Person and add validation. 
```
- Name is read-only (and assigned on construction)
- Name cannot be null
- Height & Weight cannot be negative

Throw ArgumentException or ArgumentNullException if criteria are not fulfilled. 
```

**2B** Add the method CalculateBMI to Person, which returns the BMI as a number.

**2C** Add the method GetClassification to Person, which returns the appropriate classification.

| Classification  | BMI range   |
|-----------------|-------------|
| "under-weight"  | 0 - 18.4    |
| "normal weight" | 18.5 - 24.9 |
| "over-weight"   | 25.0 - 29.9 |
| "obese"         | 30.0 -      |
