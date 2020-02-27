using System;
using NUnit.Framework;
using MovieTicketCsharp.ValueObject;

namespace MovieTicketCsharp.Test {
    public class DateVoTest {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void ValueTest() {
            var vo = new DateVo(2000, 12, 31);
            Assert.That(vo.Year, Is.EqualTo(2000));
            Assert.That(vo.Month, Is.EqualTo(12));
            Assert.That(vo.Day, Is.EqualTo(31));
        }

        [Test]
        public void ArgumentExceptionTest() {
            Assert.That(() => new DateVo(-1, 1, 1), Throws.TypeOf<ArgumentException>());

            Assert.That(() => new DateVo(2000, -1, 1), Throws.TypeOf<ArgumentException>());
            Assert.That(() => new DateVo(2000, 13, 1), Throws.TypeOf<ArgumentException>());

            Assert.That(() => new DateVo(2000, 1, -1), Throws.TypeOf<ArgumentException>());
            Assert.That(() => new DateVo(2000, 1, 32), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void IsMovieDayTest() {
            Assert.That(new DateVo(2000,12,1).IsMovieDay, Is.True);
            Assert.That(new DateVo(2000,12,2).IsMovieDay, Is.False);
        }
    }
}
