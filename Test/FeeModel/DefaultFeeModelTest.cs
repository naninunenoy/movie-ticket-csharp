using System;
using NUnit.Framework;
using MovieTicketCsharp.ValueObject;
using MovieTicketCsharp.Domain;

namespace MovieTicketCsharp.Test.FeeModel {
    public class DefaultFeeModelTest {
        DefaultFeeModel model;
        [SetUp]
        public void Setup() {
            model = new DefaultFeeModel();
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


        [TestCase(1100)]
        public void 映画の日(int price) {
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Sunday, TestAgeVo.AgeOf(69)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Monday, TestAgeVo.AgeOf(69)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Tuesday, TestAgeVo.AgeOf(69)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Wednesday, TestAgeVo.AgeOf(69)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Thursday, TestAgeVo.AgeOf(69)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Friday, TestAgeVo.AgeOf(69)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Saturday, TestAgeVo.AgeOf(69)),
                Is.EqualTo(price)
            );
        }

        [TestCase(19, 1100)]
        [TestCase(20, 1100)]
        [TestCase(4, 1100)]
        [TestCase(5, 1100)]
        public void 平日_70歳以上(int hour, int price) {
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
        public void 土日_70歳以上(int hour, int price) {
            Assert.That(
                model.Calculate(TestDateTimeVo.Saturday.SetHour(hour), TestAgeVo.AgeOf(70)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Sunday.SetHour(hour), TestAgeVo.AgeOf(70)),
                Is.EqualTo(price)
            );
        }

        [TestCase(1100)]
        public void 映画の日_70歳以上(int price) {
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Sunday, TestAgeVo.AgeOf(70)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Monday, TestAgeVo.AgeOf(70)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Tuesday, TestAgeVo.AgeOf(70)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Wednesday, TestAgeVo.AgeOf(70)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Thursday, TestAgeVo.AgeOf(70)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Friday, TestAgeVo.AgeOf(70)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Saturday, TestAgeVo.AgeOf(70)),
                Is.EqualTo(price)
            );
        }
    }
}
