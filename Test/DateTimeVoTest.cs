using System;
using NUnit.Framework;
using MovieTicketCsharp.ValueObject;

namespace MovieTicketCsharp.Test {
    public class DateTimeVoTest {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void ValueTest() {
            var dt = new DateTime(2020, 2, 28,
                12, 59, 59);
            var vo = new DateTimeVo(dt);

            Assert.That(vo.Date.Year, Is.EqualTo(2020));
            Assert.That(vo.Date.Month, Is.EqualTo(2));
            Assert.That(vo.Date.Day, Is.EqualTo(28));
            Assert.That(vo.DayOfWeek.Value, Is.EqualTo(5)); // fri
            Assert.That(vo.Time.Hour, Is.EqualTo(12));
        }
    }
}
