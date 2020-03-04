using System;
using NUnit.Framework;
using MovieTicketCsharp.ValueObject;
using MovieTicketCsharp.Domain;

namespace MovieTicketCsharp.Test.FeeModel {
    public class CinemaCitizenFeeModelTest {
        CinemaCitizenFeeModel model;

        [SetUp]
        public void Setup() {
            model = new CinemaCitizenFeeModel(59);
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
                model.Calculate(TestDateTimeVo.Monday.SetHour(hour)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Tuesday.SetHour(hour)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Wednesday.SetHour(hour)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Thursday.SetHour(hour)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Friday.SetHour(hour)),
                Is.EqualTo(price)
            );
        }

        [TestCase(19, 1300)]
        [TestCase(20, 1000)]
        [TestCase(4, 1000)]
        [TestCase(5, 1300)]
        public void 土日(int hour, int price) {
            Assert.That(
                model.Calculate(TestDateTimeVo.Saturday.SetHour(hour)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Sunday.SetHour(hour)),
                Is.EqualTo(price)
            );
        }

        [TestCase(19, 1000)]
        [TestCase(20, 1000)]
        [TestCase(4, 1000)]
        [TestCase(5, 1000)]
        public void 映画の日_平日(int hour, int price) {
            //平日なら「映画の日」に関係なく1,000円！らしい
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Monday.SetHour(hour)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Tuesday.SetHour(hour)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Wednesday.SetHour(hour)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Thursday.SetHour(hour)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Friday.SetHour(hour)),
                Is.EqualTo(price)
            );
        }

        [TestCase(19, 1100)]
        [TestCase(20, 1000)]
        [TestCase(4, 1000)]
        [TestCase(5, 1100)]
        public void 映画の日_土日(int hour, int price) {
            // 映画の日の1100円が適用されるのは土日の日中のみ?
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Sunday.SetHour(hour)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Saturday.SetHour(hour)),
                Is.EqualTo(price)
            );
        }
    }
}
