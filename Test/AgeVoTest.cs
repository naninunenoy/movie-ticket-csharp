using System;
using NUnit.Framework;
using MovieTicketCsharp.ValueObject;

namespace MovieTicketCsharp.Test {
    public class AgeVoTest {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void SetValueTest() {
            var vo = new AgeVo(100);
            Assert.That(vo.Value, Is.EqualTo(100));
        }

        [Test]
        public void ArgumentExceptionTest() {
            Assert.That(() => new AgeVo(-1), Throws.TypeOf<ArgumentException>());
        }
    }
}
