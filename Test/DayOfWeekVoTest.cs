using System;
using NUnit.Framework;
using MovieTicketCsharp.ValueObject;

namespace MovieTicketCsharp.Test {
    public class DayOfWeekVoTest {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void ValueTest() {
            var vo = new DayOfWeekVo(1);
            Assert.That(vo.Value, Is.EqualTo(1));
        }

        [Test]
        public void ArgumentExceptionTest() {
            Assert.That(() => new DayOfWeekVo(-1), Throws.TypeOf<ArgumentException>());
            Assert.That(() => new DayOfWeekVo(7), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void IsWeekendDaysTest() {
            Assert.That(new DayOfWeekVo(0).IsWeekendDays(), Is.True);
            Assert.That(new DayOfWeekVo(1).IsWeekendDays(), Is.False);
            Assert.That(new DayOfWeekVo(2).IsWeekendDays(), Is.False);
            Assert.That(new DayOfWeekVo(3).IsWeekendDays(), Is.False);
            Assert.That(new DayOfWeekVo(4).IsWeekendDays(), Is.False);
            Assert.That(new DayOfWeekVo(5).IsWeekendDays(), Is.False);
            Assert.That(new DayOfWeekVo(6).IsWeekendDays(), Is.True);
        }

        [Test]
        public void IsWeekDaysTest() {
            Assert.That(new DayOfWeekVo(0).IsWeekDays(), Is.False);
            Assert.That(new DayOfWeekVo(1).IsWeekDays(), Is.True);
            Assert.That(new DayOfWeekVo(2).IsWeekDays(), Is.True);
            Assert.That(new DayOfWeekVo(3).IsWeekDays(), Is.True);
            Assert.That(new DayOfWeekVo(4).IsWeekDays(), Is.True);
            Assert.That(new DayOfWeekVo(5).IsWeekDays(), Is.True);
            Assert.That(new DayOfWeekVo(6).IsWeekDays(), Is.False);
        }
    }
}
