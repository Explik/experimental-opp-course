using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Explik.StructuralTestTools;
using Explik.StructuralTestTools.MSTest;

namespace Lecture_2_Tests
{
    public static class TestHelper
    {
        static TestHelper()
        {
            // Forces the inclusion of the Lecture 2 Exercises assembly a class
            // from this assembly is referenced, which is neccessary for the execution 
            // of the explicit structural tests.
            Lecture_2.Program.Main(new string[0]);
        }

        public static TestFactory Factory { get; } = TestFactory.CreateFromConfigurationFile("./../../../TestToolsConfig.xml");
    }
}
