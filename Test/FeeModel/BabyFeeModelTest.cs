using System;
using NUnit.Framework;
using MovieTicketCsharp.ValueObject;
using MovieTicketCsharp.Domain;

namespace MovieTicketCsharp.Test.FeeModel {
    public class BabyFeeModelTest {
        BabyFeeModel model;

        [SetUp]
        public void Setup() {
            model = new BabyFeeModel();
        }

        [Test]
        public void InterfaceTest() {
            Assert.That(model, Is.InstanceOf<IFeeModel>());
        }

        [TestCase(19)]
        [TestCase(20)]
        [TestCase(4)]
        [TestCase(5)]
        public void 平日(int hour) {
            Assert.That(
                model.Calculate(TestDateTimeVo.Monday.SetHour(hour)),
                Is.Zero
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Tuesday.SetHour(hour)),
                Is.Zero
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Wednesday.SetHour(hour)),
                Is.Zero
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Thursday.SetHour(hour)),
                Is.Zero
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Friday.SetHour(hour)),
                Is.Zero
            );
        }

        [TestCase(19)]
        [TestCase(20)]
        [TestCase(4)]
        [TestCase(5)]
        public void 土日(int hour) {
            Assert.That(
                model.Calculate(TestDateTimeVo.Saturday.SetHour(hour)),
                Is.Zero
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Sunday.SetHour(hour)),
                Is.Zero
            );
        }

        [Test]
        public void 映画の日() {
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Sunday),
                Is.Zero
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Monday),
                Is.Zero
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Tuesday),
                Is.Zero
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Wednesday),
                Is.Zero
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Thursday),
                Is.Zero
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Friday),
                Is.Zero
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Saturday),
                Is.Zero
            );
        }
    }
}
