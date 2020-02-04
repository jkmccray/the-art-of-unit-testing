using System;
using NUnit.Framework;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnTestAssembly
    {
        public LogAnalyzer MakeAnalyzer()
        {
            LogAnalyzer la = new LogAnalyzer();
            return la;
        }

        [Test]
        public void IsValidFileName_BadExtension_ReturnsFalse()
        {
            // Arrange
            LogAnalyzer analyzer = new LogAnalyzer();

            // Act
            bool result = analyzer.IsValidLogFileName("filewithbadextension.foo");

            // Assert
            Assert.False(result);
        }

        [Test] 
        public void IsValidLogFileName_GoodExtensionLowercase_ReturnsTrue()
        {
            LogAnalyzer analyzer = new LogAnalyzer();

            bool result = analyzer.IsValidLogFileName("filewithgoodextension.slf");

            Assert.True(result);
        }

        [Test]
        public void IsValidLogFileName_GoodExtensionUppercase_ReturnsTrue()
        {
            LogAnalyzer analyzer = new LogAnalyzer();

            bool result = analyzer.IsValidLogFileName("filewithgoodextension.SLF");

            Assert.True(result);
        }

        // Change the above tests to parameterized tests
        // Another attribute means another test with a different value attached to the method parameter
        // It is possible to take this method too far and make the test too generic to be readable
        [TestCase("filewithgoodextension.SLF")]
        [TestCase("filewithgoodextension.slf")]
        public void IsValidLogFileName_ValidExtensions_ReturnsTrue(string file)
        {
            // Arrange
            LogAnalyzer analyzer = new LogAnalyzer();

            // Act
            bool result = analyzer.IsValidLogFileName(file);

            // Assert
            Assert.True(result);
        }

        // Testing for expected exceptions
        [Test]
        public void IsValidFileName_EmptyFileName_Throws()
        {
            LogAnalyzer la = MakeAnalyzer();

            var ex = Assert.Catch<Exception>(() => la.IsValidLogFileName(""));
            
            // Use the Exception object returned by Assert.Catch
            // Use .Contains to make the code more maintainable
            // Use Assert.Catch over [ExceptionExpected] attribute
            StringAssert.Contains("filename has to be provided", ex.Message);
        }

        [Test]
        public void IsValidFileName_NameSuportedExtension_ReturnsTrue()
        {
            FakeExtensionManager
        }

        //[Test]
        //public void IsValidLogFileName_BadExtension_ReturnsFalse()
        //{
        //    LogAnalyzer analyzer = new LogAnalyzer();

        //    bool result = analyzer.IsValidLogFileName("filewithbadextension.foo");

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

        //// this is a refactoring of the previous two tests
        //[TestCase("filewithgoodextension.SLF")]
        //[TestCase("filewithgoodextension.slf")]
        //public void IsValidLogFileName_ValidExtensions_ReturnsTrue(string file)
        //{
        //    LogAnalyzer analyzer = new LogAnalyzer();

        //    bool result = analyzer.IsValidLogFileName(file);

        //    Assert.True(result);
        //}

        //// this is a refactoring of all the "regular" tests
        //[TestCase("filewithgoodextension.SLF",true)]
        //[TestCase("filewithgoodextension.slf",true)]
        //[TestCase("filewithbadextension.foo",false)]
        //public void IsValidLogFileName_VariousExtensions_ChecksThem(string file, bool expected)
        //{
        //    LogAnalyzer analyzer = new LogAnalyzer();

        //    bool result = analyzer.IsValidLogFileName(file);

        //    Assert.AreEqual(expected, result);
        //}

        //[Test]
        //[ExpectedException(typeof(ArgumentException),
        //      ExpectedMessage = "filename has to be provided")]
        //public void IsValidLogFileName_EmptyFileName_ThrowsException()
        //{
        //    LogAnalyzer la = MakeAnalyzer();
        //    la.IsValidLogFileName(string.Empty);
        //}

        //private LogAnalyzer MakeAnalyzer()
        //{
        //    return new LogAnalyzer();
        //}

        //[Test]
        //public void IsValidLogFileName_EmptyFileName_Throws()
        //{
        //    LogAnalyzer la = MakeAnalyzer();

        //    var ex = Assert.Throws<ArgumentException>(() => la.IsValidLogFileName(""));

        //    StringAssert.Contains("filename has to be provided", ex.Message);
        //}

        //[Test]
        //public void IsValidLogFileName_EmptyFileName_ThrowsFluent()
        //{
        //    LogAnalyzer la = MakeAnalyzer();

        //    var ex = Assert.Throws<ArgumentException>(() => la.IsValidLogFileName(""));

        //    Assert.That(ex.Message, Is.StringContaining("filename has to be provided"));
        //}

        //[Test]
        //public void IsValidLogFileName_WhenCalled_ChangesWasLastFileNameValid()
        //{
        //    LogAnalyzer la = MakeAnalyzer();

        //    la.IsValidLogFileName("badname.foo");

        //    Assert.IsFalse(la.WasLastFileNameValid);
        //}

        ////refactored from above
        //[TestCase("badfile.foo", false)]
        //[TestCase("goodfile.slf", true)]
        //public void IsValidLogFileName_WhenCalled_ChangesWasLastFileNameValid(string file, bool expected)
        //{
        //    LogAnalyzer la = MakeAnalyzer();

        //    la.IsValidLogFileName(file);

        //    Assert.AreEqual(expected, la.WasLastFileNameValid);
        //}
    }
}
