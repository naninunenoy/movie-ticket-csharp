using System;
using NUnit.Framework;
using MovieTicketCsharp.ValueObject;
using MovieTicketCsharp.Domain;

namespace MovieTicketCsharp.Test.FeeModel {
    public class DefaultFeeModelTest {
        DefaultFeeModel model;
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void InterfaceTest() {
            Assert.That(model, Is.InstanceOf<IFeeModel>());
        }

        [TestCase(19, 1800)]
        [TestCase(20, 1300)]
        [TestCase(4, 1300)]
        [TestCase(5, 1800)]
        public void 平日(int hour, int price) {
            Assert.That(
                model.Calculate(TestDateTimeVo.Monday.SetHour(hour), TestAgeVo.AgeOf(69)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Tuesday.SetHour(hour), TestAgeVo.AgeOf(69)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Wednesday.SetHour(hour), TestAgeVo.AgeOf(69)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Thursday.SetHour(hour), TestAgeVo.AgeOf(69)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Friday.SetHour(hour), TestAgeVo.AgeOf(69)),
                Is.EqualTo(price)
            );
        }

        [TestCase(19, 1800)]
        [TestCase(20, 1300)]
        [TestCase(4, 1300)]
        [TestCase(5, 1800)]
        public void 土日(int hour, int price) {
            Assert.That(
                model.Calculate(TestDateTimeVo.Saturday.SetHour(hour), TestAgeVo.AgeOf(69)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Sunday.SetHour(hour), TestAgeVo.AgeOf(69)),
                Is.EqualTo(price)
            );
        }


        [Test]
        public void 映画の日() {
            Assert.That(
                model.Calculate(TestDateTimeVo.Sunday.SetDay(1), TestAgeVo.AgeOf(69)),
                Is.EqualTo(1100)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Sunday.SetDay(1), TestAgeVo.AgeOf(69)),
                Is.EqualTo(1100)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Monday.SetDay(1), TestAgeVo.AgeOf(69)),
                Is.EqualTo(1100)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Tuesday.SetDay(1), TestAgeVo.AgeOf(69)),
                Is.EqualTo(1100)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Wednesday.SetDay(1), TestAgeVo.AgeOf(69)),
                Is.EqualTo(1100)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Thursday.SetDay(1), TestAgeVo.AgeOf(69)),
                Is.EqualTo(1100)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Friday.SetDay(1), TestAgeVo.AgeOf(69)),
                Is.EqualTo(1100)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Saturday.SetDay(1), TestAgeVo.AgeOf(69)),
                Is.EqualTo(1100)
            );
        }

        [TestCase(19, 1100)]
        [TestCase(20, 1100)]
        [TestCase(4, 1100)]
        [TestCase(5, 1100)]
        public void 平日_60歳以上(int hour, int price) {
            Assert.That(
                model.Calculate(TestDateTimeVo.Monday.SetHour(hour), TestAgeVo.AgeOf(70)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Tuesday.SetHour(hour), TestAgeVo.AgeOf(70)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Wednesday.SetHour(hour), TestAgeVo.AgeOf(70)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Thursday.SetHour(hour), TestAgeVo.AgeOf(70)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Friday.SetHour(hour), TestAgeVo.AgeOf(70)),
                Is.EqualTo(price)
            );
        }

        [TestCase(19, 1100)]
        [TestCase(20, 1100)]
        [TestCase(4, 1100)]
        [TestCase(5, 1100)]
        public void 土日_60歳以上(int hour, int price) {
            Assert.That(
                model.Calculate(TestDateTimeVo.Saturday.SetHour(hour), TestAgeVo.AgeOf(70)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Sunday.SetHour(hour), TestAgeVo.AgeOf(70)),
                Is.EqualTo(price)
            );
        }


        [Test]
        public void 映画の日_60歳以上() {
            Assert.That(
                model.Calculate(TestDateTimeVo.Sunday.SetDay(1), TestAgeVo.AgeOf(70)),
                Is.EqualTo(1100)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Sunday.SetDay(1), TestAgeVo.AgeOf(70)),
                Is.EqualTo(1100)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Monday.SetDay(1), TestAgeVo.AgeOf(70)),
                Is.EqualTo(1100)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Tuesday.SetDay(1), TestAgeVo.AgeOf(70)),
                Is.EqualTo(1100)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Wednesday.SetDay(1), TestAgeVo.AgeOf(70)),
                Is.EqualTo(1100)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Thursday.SetDay(1), TestAgeVo.AgeOf(70)),
                Is.EqualTo(1100)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Friday.SetDay(1), TestAgeVo.AgeOf(70)),
                Is.EqualTo(1100)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Saturday.SetDay(1), TestAgeVo.AgeOf(70)),
                Is.EqualTo(1100)
            );
        }
    }
}
