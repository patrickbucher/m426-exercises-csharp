using Xunit;

namespace Grading.Tests
{
    public class GradeSheetTest
    {
        [Fact]
        public void TestOfValidCSV()
        {
            var content = @"Mathematik,3.5
                            Deutsch,5.4
                            Musik,4.2";

            var sheet = GradeSheet.of(content);

            Assert.Equal(3, sheet.GradeCount());
            Assert.True(sheet.ExportCSV().Contains("Mathematik,3.5"));
            Assert.True(sheet.ExportCSV().Contains("Deutsch,5.4"));
            Assert.True(sheet.ExportCSV().Contains("Musik,4.2"));
        }

    }
}