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

        [Fact]
        public void translating_29_results_in_XXIX()
        {
            var number = 29;
            var expectedResult = "XXIX";
            //below this line stays the same
            var translator = new Translator();
            var actualResult = translator.Translate(number);
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void translating_44_results_in_XLIV()
        {
            var number = 44;
            var expectedResult = "XLIV";
            //below this line stays the same
            var translator = new Translator();
            var actualResult = translator.Translate(number);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_45_results_in_XLV()
        {
            var number = 45;
            var expectedResult = "XLV";
            //below this line stays the same
            var translator = new Translator();
            var actualResult = translator.Translate(number);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_68_results_in_LXVIII()
        {
            var number = 68;
            var expectedResult = "LXVIII";
            //below this line stays the same
            var translator = new Translator();
            var actualResult = translator.Translate(number);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_83_results_in_LXXXIII()
        {
            var number = 83;
            var expectedResult = "LXXXIII";
            //below this line stays the same
            var translator = new Translator();
            var actualResult = translator.Translate(number);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_97_results_in_XCVII()
        {
            var number = 97;
            var expectedResult = "XCVII";
            //below this line stays the same
            var translator = new Translator();
            var actualResult = translator.Translate(number);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_99_results_in_XCIX()
        {
            var number = 99;
            var expectedResult = "XCIX";
            //below this line stays the same
            var translator = new Translator();
            var actualResult = translator.Translate(number);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_500_results_in_D()
        {
            var number = 500;
            var expectedResult = "D";
            //below this line stays the same
            var translator = new Translator();
            var actualResult = translator.Translate(number);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_501_results_in_DI()
        {
            var number = 501;
            var expectedResult = "DI";
            //below this line stays the same
            var translator = new Translator();
            var actualResult = translator.Translate(number);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_649_results_in_DCXLIX()
        {
            var number = 649;
            var expectedResult = "DCXLIX";
            //below this line stays the same
            var translator = new Translator();
            var actualResult = translator.Translate(number);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_798_results_in_DCCXCVIII()
        {
            var number = 798;
            var expectedResult = "DCCXCVIII";
            //below this line stays the same
            var translator = new Translator();
            var actualResult = translator.Translate(number);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_891_results_in_DCCCXCI()
        {
            var number = 891;
            var expectedResult = "DCCCXCI";
            //below this line stays the same
            var translator = new Translator();
            var actualResult = translator.Translate(number);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_1000_results_in_M()
        {
            var number = 649;
            var expectedResult = "DCXLIX";
            //below this line stays the same
            var translator = new Translator();
            var actualResult = translator.Translate(number);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_1004_results_in_MIV()
        {
            var number = 1004;
            var expectedResult = "MIV";
            //below this line stays the same
            var translator = new Translator();
            var actualResult = translator.Translate(number);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_1006_results_in_MVI()
        {
            var number = 1006;
            var expectedResult = "MVI";
            //below this line stays the same
            var translator = new Translator();
            var actualResult = translator.Translate(number);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_1023_results_in_MXXIII()
        {
            var number = 1023;
            var expectedResult = "MXXIII";
            //below this line stays the same
            var translator = new Translator();
            var actualResult = translator.Translate(number);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_2014_results_in_MMXIV()
        {
            var number = 2014;
            var expectedResult = "MMXIV";
            //below this line stays the same
            var translator = new Translator();
            var actualResult = translator.Translate(number);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_3999_results_in_MMMCMXCIX()
        {
            var number = 3999;
            var expectedResult = "MMMCMXCIX";
            //below this line stays the same
            var translator = new Translator();
            var actualResult = translator.Translate(number);
            Assert.Equal(expectedResult, actualResult);
        }

    }
}
