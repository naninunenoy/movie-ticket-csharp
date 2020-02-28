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
                model.Calculate(TestDateTimeVo.Monday.SetHour(3), TestAgeVo.AgeOf(0)),
                Is.EqualTo(price)
            );
        }

        [TestCase(19, 1800)]
        [TestCase(20, 1300)]
        [TestCase(4, 1300)]
        [TestCase(5, 1800)]
        public void 土日(int hour, int price) {

        }


        [Test]
        public void 映画の日() {

        }
    }
}
