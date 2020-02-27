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

        [Test]
        public void 赤ちゃんは無料() {
            Assert.That(model.Calculate(default, default), Is.Zero);
        }
    }
}
