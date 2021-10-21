using Explik.StructuralTestTools;
using Explik.StructuralTestTools.MSTest;
using Lecture_9_Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections.Specialized;
using static Lecture_9_Tests.TestHelper;

namespace Lecture_9_Tests
{
    [TemplatedTestClass]
    public class Exercise_4_Tests_Template
    {
        #region Exercise 4A

        [TestMethod("a. ObservableCollection<T> implements ICollection<T>"), TestCategory("Exercise 4A")]
        public void ObservableCollectionImplementsICollection()
        {
            // This code is specific to StructuralTestTools
            StructureTest test = Factory.CreateStructureTest();
            test.AssertClass<ObservableCollection<int>>(new TypeIsSubclassOfVerifier(typeof(ICollection<int>)));
            test.Execute();
        }

        #endregion Exercise 4A

        #region Exercise 4B

        [TestMethod("a. ObservableCollection<T> implements INotifyCollectionChanged"), TestCategory("Exercise 4B")]
        public void ObservableCollectionImplementsINotifyCollectionChanged()
        {
            // This code is specific to StructuralTestTools
            StructureTest test = Factory.CreateStructureTest();
            test.AssertClass<ObservableCollection<int>>(new TypeIsSubclassOfVerifier(typeof(INotifyCollectionChanged)));
            test.Execute();
        }

        [TemplatedTestMethod("b. ObservableCollection<T>.Add(T elem) emits CollectionChanged event"), TestCategory("Exercise 4B")]
        public void ObservableCollectionAddEmitsCollectionChangedEvents()
        {
            bool isCalled = false;
            ObservableCollection<int> collection = new ObservableCollection<int>();
            collection.CollectionChanged += (sender, e) => isCalled = true;

            collection.Add(5);

            Assert.IsTrue(isCalled, "The ObservableCollection<T>.CollectionChanged event is never emitted");
        }

        [TemplatedTestMethod("c. ObservableCollection<T>.Clear() emits CollectionChanged event"), TestCategory("Exercise 4B")]
        public void ObservableCollectionClearEmitsCollectionChangedEvent()
        {
            bool isCalled = false;
            ObservableCollection<int> collection = new ObservableCollection<int>() { 1 };
            collection.CollectionChanged += (sender, e) => isCalled = true;

            collection.Clear();

            Assert.IsTrue(isCalled, "The ObservableCollection<T>.CollectionChanged event is never emitted");
        }

        [TemplatedTestMethod("d. ObservableCollection<T>.Remove(T elem) emits CollectionChanged event"), TestCategory("Exercise 4B")]
        public void ObservableCollectionRemoveEmitsCollectionChangedEvent()
        {
            bool isCalled = false;
            ObservableCollection<int> collection = new ObservableCollection<int>() { 1 };
            collection.CollectionChanged += (sender, e) => isCalled = true;

            collection.Remove(1);

            Assert.IsTrue(isCalled, "The ObservableCollection<T>.CollectionChanged event is never emitted");
        }

        #endregion Exercise 4B
    }
}