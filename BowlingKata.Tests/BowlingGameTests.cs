using System;
using FluentAssertions;
using Moq.AutoMock;
using AutoFixture;
using Xunit;

namespace BowlingKata.Tests
{
    public class BowlingGameTests
    {
        public Fixture AutoFixture { get; set; }
        public AutoMocker Mocker { get; set; }

        public BowlingGameTests()
        {
            AutoFixture = new Fixture();
            Mocker = new AutoMocker();            
        }

        [Fact]
        public void WhenNewGame(){
            //Arrange
            var subject = Mocker.CreateInstance<BowlingGame>();

            //Act
            var result = subject.NewGame();

            //Assert
            result.Should().BeOfType<Game>();
        }
    }
}
