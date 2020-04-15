using System;
using Xunit;

namespace BadSuperBowlNamer.Tests
{
    // with tests, we optimize for readability 
    public class int_to_roman_numerals
    {
        // things in square brackets add metadata
        // in TDD, developers often code out things that do not work immediately with the understanding that we will code it out later
        [Fact]
        public void translating_1_results_in_I()
        {
            // Arrange - set up context for what will come in our test
            var number = 1;
            var expectedResult = "I";
            var translator = new Translator();

            // Act
            var actualResult = translator.Translate(number);

            // Assert - typically use an assertion library. x-unit comes built in with one

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_5_results_in_V()
        {
            // Arrange - set up context for what will come in our test
            var number = 5;
            var expectedResult = "V";
            var translator = new Translator();

            // Act
            var actualResult = translator.Translate(number);

            // Assert - typically use an assertion library. x-unit comes built in with one

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_9_results_in_IX()
        {
            // Arrange - set up context for what will come in our test
            var number = 9;
            var expectedResult = "IX";
            var translator = new Translator();

            // Act
            var actualResult = translator.Translate(number);

            // Assert - typically use an assertion library. x-unit comes built in with one

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_12_results_in_XII()
        {
            // Arrange - set up context for what will come in our test
            var number = 12;
            var expectedResult = "XII";
            var translator = new Translator();

            // Act
            var actualResult = translator.Translate(number);

            // Assert - typically use an assertion library. x-unit comes built in with one

            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void translating_14_results_in_XIV()
        {
            // Arrange - set up context for what will come in our test
            var number = 14;
            var expectedResult = "XIV";
            var translator = new Translator();

            // Act
            var actualResult = translator.Translate(number);

            // Assert - typically use an assertion library. x-unit comes built in with one

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
