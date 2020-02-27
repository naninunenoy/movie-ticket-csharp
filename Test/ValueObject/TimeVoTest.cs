using System;
using NUnit.Framework;
using MovieTicketCsharp.ValueObject;

namespace MovieTicketCsharp.Test.ValueObject {
    public class TimeVoTest {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void HourTest() {
            var vo = new TimeVo(15);
            Assert.That(vo.Hour, Is.EqualTo(15));
        }

        [Test]
        public void ArgumentExceptionTest() {
            Assert.That(() => new TimeVo(-1), Throws.TypeOf<ArgumentException>());
            Assert.That(() => new TimeVo(24), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void IsLateTest() {
            Assert.That(new TimeVo(19).IsLate(), Is.False);
            Assert.That(new TimeVo(20).IsLate(), Is.True);
            Assert.That(new TimeVo(4).IsLate(), Is.True);
            Assert.That(new TimeVo(5).IsLate(), Is.False);
        }
    }
}
