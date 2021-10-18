using Explik.StructuralTestTools;
using Explik.StructuralTestTools.MSTest;
using Lecture_6_Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using static Lecture_6_Tests.TestHelper;

namespace Lecture_6_Tests
{
    [TemplatedTestClass]
    public class Exercise_6_Tests_Template
    {
        #region Exercise 6A

        [TestMethod("a. ILogger is an interface"), TestCategory("Exercise 6A")]
        public void ILoggerIsAnInterface()
        {
            // This code is specific to StructuralTestTools
            StructureTest test = Factory.CreateStructureTest();
            test.AssertInterface<ILogger>();
            test.Execute();
        }

        [TestMethod("b. ILogger.Log(string message) is a method"), TestCategory("Exercise 6A")]
        public void ILoggerLogIsAMehthod()
        {
            // This code is specific to StructuralTestTools
            StructureTest test = Factory.CreateStructureTest();
            test.AssertPublicMethod<ILogger, string>((l, s) => l.Log(s));
            test.Execute();
        }

        #endregion Exercise 6A

        #region Exercise 6B

        [TestMethod("a. FileLogger's constructor takes string"), TestCategory("Exercise 6B")]
        public void DieConstructorTakesIRandomAndInt()
        {
            // This code is specific to StructuralTestTools
            StructureTest test = Factory.CreateStructureTest();
            test.AssertPublicConstructor<string, ILogger>(s => new FileLogger(s));
            test.Execute();
        }

        #endregion Exercise 6B

        #region Exercise 6C

        [TestMethod("a. FileLogger implements ILogger"), TestCategory("Exercise 6C")]
        public void FileLoggerImplementILogger()
        {
            // This code is specific to StructuralTestTools
            StructureTest test = Factory.CreateStructureTest();
            test.AssertClass<FileLogger>(
                new TypeAccessLevelVerifier(AccessLevels.Public),
                new TypeIsSubclassOfVerifier(typeof(ILogger)));
            test.Execute();
        }

        #endregion Exercise 6C

        #region Exercise 6D

        [TestMethod("a. FileLogger implements IDisposable"), TestCategory("Exercise 6D")]
        public void FileLoggerImplementIDisposable()
        {
            // This code is specific to StructuralTestTools
            StructureTest test = Factory.CreateStructureTest();
            test.AssertClass<FileLogger>(
                new TypeAccessLevelVerifier(AccessLevels.Public),
                new TypeIsSubclassOfVerifier(typeof(IDisposable)));
            test.Execute();
        }

        #endregion Exercise 6D

        #region Exercise 6E

        private void FileLoggerAppendsFileSetup()
        {
            string path = "./log.txt";

            if (File.Exists(path))
                File.Delete(path);
            File.WriteAllText(path, "Customer Ryan Johnson was created" + Environment.NewLine);
        }

        [TemplatedTestMethod("a. FileLogger.Log(string message) appends file"), TestCategory("Exercise 6E")]
        public void FileLoggerAppendsFile()
        {
            FileLoggerAppendsFileSetup();

            FileLogger logger = new FileLogger("./log.txt");

            logger.Log("Customer Ryan Johnson was deleted");
            logger.Dispose();

            string expectedContent = string.Join(
                Environment.NewLine,
                "Customer Ryan Johnson was created",
                "Customer Ryan Johnson was deleted");
            Assert.AreEqual(expectedContent, File.ReadAllText("./log.txt"));
        }

        #endregion Exercise 6E

        #region Exercise 6F

        [TemplatedTestMethod("a. ConsoleLogger.Log(string message) writes to console"), TestCategory("Exercise 6F")]
        public void ConsoleLoggerWritesToConsole()
        {
            ConsoleLogger logger = new ConsoleLogger();

            string expectedWriteout = "Customer Ryan Johnson was deleted";
            ConsoleAssert.WritesOut(() => logger.Log("Customer Ryan Johnson was deleted"), expectedWriteout);
        }

        #endregion Exercise 6F
    }
}