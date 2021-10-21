# Lecture 9 exercises

## Exercise 1

Create a class SortedCollection<T> which represents a collection that maintains the proper ordering of elements whenever elements are added or removed.
  
**1A)** Implement the ICollection interface in a manner that upholds ordering. In order to uphold the ordering, you must specify a constraint such that only elements that implement IComparable can be inserted. 
  
**1B)** Implement a read-only index operator. 
  
**1C)** Implement a method GetAll and GetAllReversed, which returns an enumerates the collection from start to end and from end to start. 

**1D)**  Implement an overload of GetAll and GetAllReversed which takes a predicate.
  
## Exercise 2

Create classes Student and Course.

**2A)** Add properties ID, FirstName, LastName, Age to Student.
  
**2B)** Add property read-only property Students to Course, and implement Enroll and Disenroll to add or remove students.
  
**2C)** Implement GetStudentByID, GetYoungestStudent, GetOldestStudent and GetAverageStudentAge in Course.
  
## Exercise 3
  
Create classes Product and ProductRepository
  
**3A)** Add properties ID, Title, Category, Price to Product, and implement GetEquals and GetHashCode based on ID.
  
**3B)** Implement the IEnumerable interface on ProductRepository in such a way that there never is direct access to the internal collection of the product. *Hint: Linq select.*
  
**3C)** Implement Add, Update and Delete on ProductRepository in such a way that there never is direct access to the internal collection of the product. *Hint: object.MemberwiseClone().*
  
**3D)** Implement GetProductByID, GetLeastExpensiveProduct, GetMostExpensiveProduct, GetAverageProductPrice, GetProductsInCategory and GetProductCategories.
  
## Exercise 4
  
Explain, in your own words, the purpose of the INotifyCollectionChanged interface.
  
**4A)** Create a class ObservableCollection<T>, and implement the ICollection<T> interface.
  
**4B)**  Implement the INotifyCollectionChanged interface as well.
