# Lecture 7 exercises

## Exercise 1

Explain, in your own words, the concept of generics. 
```C#
class Pair<T1, T2>
{
  T1 Fst;
  T2 Snd;
}
```

**1A)** Make Fst and Snd read-only fields.

**1B)** Add an appropriate constructor, which sets Fst and Snd.

**1C)** Add a method Swap(). The swap method should return a new MyTuple where the first component becomes the second component and vice versa. For example, for the pair (true, 42) the method should return (42, true). *Hint: You will have to swap the type parameters in the return type.*

**1D)** Add methods SetFst and SetSnd to the MyTuple class. Each method should take a type parameter C and return a new pair where the appropriate component has been updated. For example, calling setFst with the integer 42 on the pair (true, "Hello World") should return (42, "Hello World"). 

## Exercise 2

Explain, in your own words, the difference between a stack and a queue. 

**2A)** Create a public class MyQueue with a type parameter T, which represents a queue of objects (of type T). 

**2B)** Add a constructor, which sets the max queue length, and add a read-only property called MaxCount, which represents the max queue length.

**2C)** Add a read-only property called Count, which represents the number of objects in the queue.

**2D)** Add a method Enqueue, which adds an object to the queue. Add a method Dequeue, which takes an object from the queue. Enqueue should throw an InvalidOperationException if the queue is already full when Enqueue is called. Dequeue should throw an InvalidOperationException if the queue is already empty when Dequeue is called.

**2E)** Add a method Peek, which does not modify the queue. Peek should throw an InvalidOperationException if the queue is already empty when Peek is called. 

## Exercise 3

Explain, in your own words, the ICloneable interface.

**3A)** Create the class Dog, add properties ID, Name, Breed and Age and add validation.
```
Validation criteria: 
- ID and Age should always be positive.

Throw ArgumentException or ArgumentNullException if a criterion is not fulfilled.
```

**3B)** Implement ICloneable in Dog, which clones the dog.

**3C)** Implement specialized versions of Equals and GetHashCode in Dog, which equates dogs with the same id.

**3D)** Implement a specialized version of the method ToString in Dog, which produces the string as below.
```C#
"Dog Bella (3)"
```

## Exercise 4

Explain, in your own words, the concept of CRUD operations.

**4A)** Create the class Repository with a Type parameter TEntity, which represents a collection of entities (of type T). The repository should store the entities in an internal list, which elements are not accessible from the outside apart from Add, GetAll, Update and Delete. So that any modifications to objects outside of Add, Update and Delete will not result in changes in the repository. *Hint: ICloneable.*

**4B)** Create a method Add, which adds a copy of the entity to the repository. 

**4C)** Create a method GetAll, which returns a copy of all entities in the repository.

**4D)** Create a method Update, which updates the entity. 

**4E)** Create a method Delete, which removes the entity from the repository.

## Exercise 5

Explain, in your own words, the concept of a static class.

**5A)** Create a public static class ArrayHelper.

**5B)** Implement the method Min, which finds the “smallest” object from an array of comparable objects. For example, 2 in [2, 5, 3].

**5C)** Implement the method Max, which finds the “largest” object from an array of comparable objects. For example, 5 in [2, 5, 3].

**5D)** Implement a method Copy, which returns a copy of an array by copying all the entries from the original to the copy. 

**5E)** Implement a method Shuffle(T[]), which swaps each element in the array with another random element in the array. *Hint: Random.*

# Rehearsal of Lecture 6

## Exercise 6

**6A)** Create an interface ILogger with a method void Log(string).

**6B)** Create a class Logger, which implements ILogger, and stores the logs in a read-only property List<string> Logs.
  
**6C)** Add a constructor to Repository, which injects an ILogger.
  
**6D)** Modify the Repository methods so that if a logger was injected. Modifications to the repository is logged as below. 

```
Dog Max (43) was updated
Dog Bella (3) was deleted
Dog Oscar (103) was added
```



