using System;
using FluentAssertions;
using Moq.AutoMock;
using AutoFixture;
using Xunit;

namespace BowlingKata.Tests
{
    public class GameTests
    {
        public Fixture AutoFixture { get; set; }
        public AutoMocker Mocker { get; set; }

        public GameTests()
        {
            AutoFixture = new Fixture();
            Mocker = new AutoMocker();            
        }
        [Fact]
        public void WhenGutterGame(){
            //Arrange
            var subject = Mocker.CreateInstance<Game>();

            //Act
            subject.RollMany(20, 0);
            var result = subject.Score();

            //Assert
            result.Should().Be(0);
        }
        [Fact]
        public void WhenAllSingles(){
            //Arrange
            var subject = Mocker.CreateInstance<Game>();

            //Act
            subject.RollMany(20, 1);
            var result = subject.Score();

            //Assert
            result.Should().Be(20);
        }
        [Fact]
        public void WhenSpare(){
            //Arrange
            var subject = Mocker.CreateInstance<Game>();

            //Act
            subject.RollMany(2, 5);
            subject.RollMany(1, 3);
            subject.RollMany(17, 0);
            var result = subject.Score();

            //Assert
            result.Should().Be(16);
        }
    }
}
