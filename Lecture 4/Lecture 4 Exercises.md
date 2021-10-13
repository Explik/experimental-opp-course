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

**2A)** Add the properties Name, Height, and Weight to Person and add validation. 
```
- Name is read-only (and assigned on construction)
- Name cannot be null
- Height & Weight cannot be negative

Throw ArgumentException or ArgumentNullException if criteria are not fulfilled. 
```

**2B)** Add the method CalculateBMI to Person, which returns the BMI as a number.

**2C)** Add the method GetClassification to Person, which returns the appropriate classification.

| Classification  | BMI range   |
|-----------------|-------------|
| "under-weight"  | 0 - 18.4    |
| "normal weight" | 18.5 - 24.9 |
| "over-weight"   | 25.0 - 29.9 |
| "obese"         | 30.0 -      |

## Exercise 3
Explain, in your own words, the concept of test-driven development. 

**3A)** Create a new class MyStack in its own file.

**3B)** Add the following members to MyStack without implementing them. *Hint: NotImplementedException.*
```
Constructors: 
- Stack(int capacity)

Properties: 
- int Count

Methods: 
- object Peek()
- object Pop()
- void Push()
- void Clear()
```

**3C)** Write a unit test for each class member.

**3D)** Implement each member, so that they satisfy the tests. Internally the class should use an array of objects to represent the stack. 

## Exercise 4
Create a new class MyString in its own file. 

**4A)** Add the following members to MyString without implementing them. *Hint: NotImplementedException.*
```
Constructors: 
- MyString(char[] chars)

Readonly properties: 
- int Length

Methods: 
- MyString ToLower()
- MyString ToUpper()
- MyString Trim()
- MyString Contains(MyString str)
- MyString Substring(int start, int end)
- MyString Split(char c)
- MyString Split(char[] c)
- bool Equals()
- int GetHashCode()
```

**4B)** Write a unit tests for each class member

**4C)** Implement each member, so that they satisfy the tests. Internally the class should use an array of characters to represent the string.  

## Exercise 5
Create a new class MyTimeSpan in its own file. 

**5A)** Add the following members to MyTimeSpan to the class without implementing them. *Hint: NotImplementedException.*
```
Constructors: 
- MyTimeSpan(long milliseconds)
- MyTimeSpan(long hours, long minutes, long seconds)

Readonly properties: 
- long Milliseconds
- long Seconds
- long Minutes
- long Hours
- long Days
- long TotalSeconds

Methods: 
- MyTimeSpan Add(MyTimeSpan ts)
- MyTimeSpan Subtract(MyTimeSpan ts)
- MyTimeSpan Multiply(double factor)
```

**5B)** Write a unit test for each constructor, property and method

**5C)** Implement each constructor, property and method. Internally the class should store the time in milliseconds. 

## Exercise 6
Explain, in your own words, the concept of code coverage. 

**6A)** Create new class Calculator in its own file.

**6B)** Add the following members to Calculator class without implementing them. *Hint: NotImplementedException.*
```
Properties: 
- IsRunning (read-only)
- Total 

Methods: 
- Start
- Stop

Methods: 
- HandleInput()
- ParseOperand(string rawOperand)
- PerformOperation(char operator, double operand)
```

**6C)** Write a unit test for each member, if possible. 

**6D)** Implement each member, so that they satisfy the tests. 

**6E)** Do a manual test to check if the Calculator is functional 

Final calculator running in the console: 
```
> + 5
5
> / 3
1.66
> * pi
5.23
>

```

# Rehearsal of Lecture 3

## Exercise 7

**7A)** Make NotOldEnoughException a subclass of Exception.

**7B)** Add a parameterless constructor, which sets the message to “Person is too young”. *Hint: base constructor.*

**7C)** Add a constructor, which takes the activity as a parameter and sets the message to “Person is too young to [activity]”.

**7D)** Add the property Age to Person and modify CalculateBMI method, so that it throws a NotOldEnoughException with the message “Person is too young to calculate BMI” if age is under 16.







