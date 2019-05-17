using NUnit.Framework;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Daily_Programmer.Tests
{
    [TestFixture]
    class Add_Digits_Test
    {
        private readonly Add_Digits Add_Digits;

        public Add_Digits_Test()
        {
            Add_Digits = new Add_Digits();
        }

        [TestCase(1)]
        public void Input_IsA_NonNegativeNumber(int input)
        {
            var sut = Add_Digits.Calculate(input);

            sut.Should().BePositive();
        }

    }
}
