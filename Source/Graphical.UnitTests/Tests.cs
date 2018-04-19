using FluentAssertions;
using NUnit.Framework;

namespace Graphical.UnitTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void FirstTest()
        {
            var graph = new Graph();
            graph.Should().NotBeNull();
        }
    }
}