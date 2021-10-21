using Explik.StructuralTestTools.MSTest;

namespace Lecture_9_Tests
{
    public static class TestHelper
    {
        public static TestFactory Factory { get; } = TestFactory.CreateFromConfigurationFile("./../../../TestToolsConfig.xml");
    }
}