using System;
using NUnit.Framework;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnTestAssembly
    {
        //public LogAnalyzer MakeAnalyzer()
        //{
        //    LogAnalyzer la = new LogAnalyzer();
        //    return la;
        //}

        //[Test]
        //public void IsValidFileName_BadExtension_ReturnsFalse()
        //{
        //    // Arrange
        //    LogAnalyzer analyzer = new LogAnalyzer();

        //    // Act
        //    bool result = analyzer.IsValidLogFileName("filewithbadextension.foo");

        //    // Assert
        //    Assert.False(result);
        //}

        //[Test] 
        //public void IsValidLogFileName_GoodExtensionLowercase_ReturnsTrue()
        //{
        //    LogAnalyzer analyzer = new LogAnalyzer();

        //    bool result = analyzer.IsValidLogFileName("filewithgoodextension.slf");

        //    Assert.True(result);
        //}

        //[Test]
        //public void IsValidLogFileName_GoodExtensionUppercase_ReturnsTrue()
        //{
        //    LogAnalyzer analyzer = new LogAnalyzer();

        //    bool result = analyzer.IsValidLogFileName("filewithgoodextension.SLF");

        //    Assert.True(result);
        //}

        //// Change the above tests to parameterized tests
        //// Another attribute means another test with a different value attached to the method parameter
        //// It is possible to take this method too far and make the test too generic to be readable
        //[TestCase("filewithgoodextension.SLF")]
        //[TestCase("filewithgoodextension.slf")]
        //public void IsValidLogFileName_ValidExtensions_ReturnsTrue(string file)
        //{
        //    // Arrange
        //    LogAnalyzer analyzer = new LogAnalyzer();

        //    // Act
        //    bool result = analyzer.IsValidLogFileName(file);

        //    // Assert
        //    Assert.True(result);
        //}

        // Testing for expected exceptions
        //[Test]
        //public void IsValidFileName_EmptyFileName_Throws()
        //{
        //    LogAnalyzer la = MakeAnalyzer();

        //    var ex = Assert.Catch<Exception>(() => la.IsValidLogFileName(""));
            
        //    // Use the Exception object returned by Assert.Catch
        //    // Use .Contains to make the code more maintainable
        //    // Use Assert.Catch over [ExceptionExpected] attribute
        //    StringAssert.Contains("filename has to be provided", ex.Message);
        //}

        [Test]
        public void IsValidFileName_NameSuportedExtension_ReturnsTrue()
        {
            FakeExtensionManager myFakeManager = new FakeExtensionManager();
            myFakeManager.WillBeValid = true;
            LogAnalyzer log = new LogAnalyzer(myFakeManager);
            bool result = log.IsValidLogFileName("short.ext");
            Assert.True(result);
        }

        [Test]
        public void IsValidFileName_SupportedExtension_ReturnsTrue()
        {
            // set up stub to use, make sure it returns true
        }
       
    }
}
