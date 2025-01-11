using System;
using Xunit;
using Moq;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using myMath;

namespace myMath.Tests
{
    public partial class ProgramTests
    {
        [Theory]
        [InlineData(5, 1, 10)]
        [InlineData(5, 2, 25)]
        [InlineData(5, 3, 10)]
        [InlineData(5, 4, 25)]
        public void TestPerformOperation(int num1, int op, int expected)
        {
            int result = Helpers.PerformAnOperation(op, num1);
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// Tests the DoSomething2 method of the Helpers class with various input values.
        /// </summary>
        /// <param name="a">The first integer input value.</param>
        /// <param name="b">The second integer input value.</param>
        /// <param name="expected">The expected boolean output value.</param>
        [Theory]
        [InlineData(0, 4, true)]
        [InlineData(2, 0, false)]
        [InlineData(6, 3, true)]
        public void TestDoSomething2(int a, int b, bool expected)
        {
            var simpleMathMock = new Mock<SimpleMath>();
            _ = simpleMathMock.Setup(s => s.Divider(a, b)).Returns(expected ? a / b : throw new ArgumentOutOfRangeException(message: "Denomenator cannot be zero.", innerException: null));

            bool result = Helpers.ValidateAndCompareNumbers(a, b);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestGetNumberInput()
        {
            int result = Helpers.GetNumberInput();
            Assert.Equal(5, result);
        }

/*
 * [Fact]
        public void TestSelectOperation()
        {
            int expected = 1;
            var mockHelper = new Mock<Helpers>();
            mockHelper.Setup(h => h.SelectOperation()).Returns(expected);

            char result = mockHelper.Object.SelectOperation();
            Assert.Equal(expected, result);
        }
*/

        [Theory]
        [InlineData("20130816", "yyyyMMdd", "2013-08-16T00:00:00.0000000")]
        [InlineData("20131608", "yyyyMMdd", "Cannot convert 20131608")]
        [InlineData("  20130816   ", "yyyyMMdd", "2013-08-16T00:00:00.0000000")]
        [InlineData("115216", "HHmmss", "11:52:16")]
        [InlineData("521116", "HHmmss", "Cannot convert 521116")]
        [InlineData("  115216  ", "HHmmss", "11:52:16")]
        public void TestDoSomething2_DateTime(string dateString, string format, string expectedString)
        {
            Regex regex = MyRegex();
            DateTime expected = DateTime.MinValue;
            if (regex.Match(expectedString).Success)
            {
                _ = DateTime.TryParse(expectedString, out expected);
            }

            string[] formats = { format };
            string[] dateStrings = { dateString };
            string formatChange = "";


            foreach (var dateStringItem in dateStrings)
            {
                if (DateTime.TryParseExact(dateStringItem, formats, null,
                               System.Globalization.DateTimeStyles.AllowWhiteSpaces |
                               System.Globalization.DateTimeStyles.AdjustToUniversal,
                               out DateTime parsedDate))
                {
                    formatChange += dateStringItem + " --> " + parsedDate + "\n";
                    Assert.Equal(expected, parsedDate);
                }
                else
                    formatChange += "Cannot convert " + dateStringItem + "\n";
            }
        }

        [GeneratedRegex("\\d{4}-\\d{2}-\\d{2}T\\d{2}:\\d{2}:\\d{2}")]
        private static partial Regex MyRegex();

        /*
         * [Fact]
               public async Task TestWriteMessage()
               {
                   var handlerMock = new Mock<HttpMessageHandler>();
                   var client = new MyClient(handlerMock.Object);

                   string expected = "test message";

                   handlerMock.Protected()
                               .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>())
                               .ReturnsAsync(new HttpResponseMessage
                               {
                                   StatusCode = HttpStatusCode.OK,
                                   Content = new StringContent(expected),
                               });

                   string result = await client.WriteMessageAsync("test message");

                   Assert.Equal(expected, result);
               }
        */
    }
}