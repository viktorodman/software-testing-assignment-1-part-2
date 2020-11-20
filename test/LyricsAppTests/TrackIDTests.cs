using System;
using Xunit;
using Model;

namespace LyricsAppTests
{
    public class TrackIDTests
    {
        [Fact]
        public void GetID_ID_ReturnsID()
        {
            string input = "15953433";

            Track sut = new Track(input);

            string expected = input;
            string actual = sut.ID;

            Assert.Equal(expected, actual);
        }
    }
}