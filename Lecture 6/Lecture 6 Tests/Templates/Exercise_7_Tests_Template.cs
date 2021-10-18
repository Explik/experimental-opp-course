﻿using Explik.StructuralTestTools;
using Explik.StructuralTestTools.MSTest;
using Lecture_6_Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using static Lecture_6_Tests.TestHelper;

namespace Lecture_6_Tests
{
    [TemplatedTestClass]
    public class Exercise_7_Tests_Template
    {
        #region Exercise 7A

        [TestMethod("a. TextFile constructor takes string"), TestCategory("Exercise 7A")]
        public void TextFileConstructorTakesString()
        {
            // TestTools Code
            StructureTest test = Factory.CreateStructureTest();
            test.AssertPublicConstructor<string, TextFile>(s => new TextFile(s));
            test.Execute();
        }

        #endregion Exercise 7A

        #region Exercise 7B

        [TestMethod("a. TestFile.Content is public read-only string"), TestCategory("Exercise 7B")]
        public void TestFileContentIsPublicReadOnlyString()
        {
            // TestTools Code
            StructureTest test = Factory.CreateStructureTest();
            test.AssertPublicReadonlyProperty<TextFile, string>(t => t.Content);
            test.Execute();
        }

        private void TestSetup()
        {
            File.WriteAllText("./file.txt", "content of file");
        }

        [TemplatedTestMethod("b. TestFile.Content reads file content correctly"), TestCategory("Exercise 7B")]
        public void TestFileContentReadsFileContentCorrectly()
        {
            TestSetup();

            TextFile file = new TextFile("./file.txt");
            Assert.AreEqual("content of file", file.Content);
            file.Dispose();
        }

        #endregion Exercise 7B

        #region Exercise 7C

        [TestMethod("a. TextFile implements IDisposable"), TestCategory("Exercise 7C")]
        public void TextFileImplementsIDisposable()
        {
            // TestTools Code
            StructureTest test = Factory.CreateStructureTest();
            test.AssertClass<TextFile>(new TypeIsSubclassOfVerifier(typeof(IDisposable)));
            test.Execute();
        }

        [TemplatedTestMethod("b. TextFile.Content equals null after TextFile.Dispose()"), TestCategory("Exercise 7C")]
        public void TextFileContentEqualsNullAfterDisposable()
        {
            TestSetup();

            TextFile file = new TextFile("./file.txt");

            file.Dispose();

            Assert.IsNull(file.Content);
        }

        #endregion Exercise 7C
    }
}