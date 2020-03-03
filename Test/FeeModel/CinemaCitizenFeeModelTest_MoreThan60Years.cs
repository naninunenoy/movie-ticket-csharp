using System;
using NUnit.Framework;
using MovieTicketCsharp.ValueObject;
using MovieTicketCsharp.Domain;

namespace MovieTicketCsharp.Test.FeeModel {
    public class CinemaCitizenFeeModelTest_MoreThan60Years {
        CinemaCitizenFeeModel model;

        [SetUp]
        public void Setup() {
            model = new CinemaCitizenFeeModel(60);
        }

        [Test]
        public void InterfaceTest() {
            Assert.That(model, Is.InstanceOf<IFeeModel>());
        }

        [TestCase(19, 1000)]
        [TestCase(20, 1000)]
        [TestCase(4, 1000)]
        [TestCase(5, 1000)]
        public void 平日(int hour, int price) {
            Assert.That(
                model.Calculate(TestDateTimeVo.Monday.SetHour(hour), TestAgeVo.AgeOf(60)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Tuesday.SetHour(hour), TestAgeVo.AgeOf(60)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Wednesday.SetHour(hour), TestAgeVo.AgeOf(60)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Thursday.SetHour(hour), TestAgeVo.AgeOf(60)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Friday.SetHour(hour), TestAgeVo.AgeOf(60)),
                Is.EqualTo(price)
            );
        }

        [TestCase(19, 1000)]
        [TestCase(20, 1000)]
        [TestCase(4, 1000)]
        [TestCase(5, 1000)]
        public void 土日(int hour, int price) {
            Assert.That(
                model.Calculate(TestDateTimeVo.Saturday.SetHour(hour), TestAgeVo.AgeOf(60)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Sunday.SetHour(hour), TestAgeVo.AgeOf(60)),
                Is.EqualTo(price)
            );
        }

        [TestCase(1000)]
        public void 映画の日_平日(int price) {
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Sunday, TestAgeVo.AgeOf(60)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Monday, TestAgeVo.AgeOf(60)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Tuesday, TestAgeVo.AgeOf(60)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Wednesday, TestAgeVo.AgeOf(60)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Thursday, TestAgeVo.AgeOf(60)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Friday, TestAgeVo.AgeOf(60)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Saturday, TestAgeVo.AgeOf(60)),
                Is.EqualTo(price)
            );
        }
    }
}

