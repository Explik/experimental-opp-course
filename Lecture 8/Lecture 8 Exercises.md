# Lecture 8 exercises

## Exercise 1

Create a static class ArrayHelper with the following methods.
```C#
T[] Filter<T>(T[] array, [delegate] predicate)
T2[] Map<T1, T2>(T1[] array, [delegate] mappingFunc)
T[] Sort<T>(T[] array, [delegate] comparerFunc)
T Find<T>(T[] array, [delegate] predicate)
bool Contains(T[] array, [delegate] predicate)
```

**1A)** Determine the appropriate built-in delegates, Func, Action, Predicate.

**1B)** Implement the methods.

## Exercise 2

Explain, in your own words, the concept of events.

**2A)** Create a class BankAccount with a read-only property Balance, which represents a monetary amount. *Hint: decimal struct.*

**2B)** Add the properties LowBalanceThreshold and HighBalanceThreshold, and add validation.
```
Validation criteria:   
- LowBalanceThreshold must always be smaller or equal to MaxBalance.
- HighBalanceThreshold must always be larger or equal to MinBalance.

Throw ArgumentException if criteria is not fulfilled.
```

**2C)** Implement the methods Deposit and Withdraw, which modifies the balance by an amount. Throw ArgumentException if the amount is negative. 

**2D)** Implement a delegate BalanceChangeHandler, outside of BankAccount, which takes the current balance and returns nothing. 

**2E)** Implement two events BalanceLowEvent and BalanceHighEvent based on BalanceChangeHandler, which are called when the balance either goes above MaxBalance or goes below MinBalance.

## Exercise 3

Create a class ConsoleView.

**3A)** Implement method Run, which contains a while loop that reads lines from the console until it reads an empty line. 

**3B)** Create a delegate InputHandler, outside of ConsoleView, which takes a string and returns nothing. 

**3C)** Add event Input to ConsoleView, and modify the Run loop so that the Input is invoked for each reed line.

## Exercise 4 

Create a class ConsoleController.

**4A)** Create an internal dictionary called _commands, which represents names commands, which takes a string as an argument.

**4B)** Create a method HandleInput, which matches the InputHandler delegate, and executes the appropriate command or writes “Command [name] not found”. Exemplified use below: 

controller.HandleInput(“Echo Hello World”)
```
Hello World
```

controller.HandleInput(“Reverse Hello World”)
```
dlroW olleH
```

controller.HandleInput(“Greet World”)
```
Hello World
```

controller.HandleInput(“NonExistentCommand Hello World”)
```
Command NonExistentCommand not found
```

controller.HandleInput(“Greet”)
```
Please provide a command argument
```

controller.HandleInput(“”)
```
Please provide a command
```

**4C)** Add a method AddCommand, which adds a command to _commands.

**4D)** Add a method RemoveCommand, which adds a command to _commands.

## Exercise 5

Explain, in your own words, the INotifyPropertyChanged interface.

**5A)** Create a class Customer with the properties ID, FirstName and LastName.

**5B)** Implement the INotifyPropertyChanged interface, and use it to notify all changed property values.




