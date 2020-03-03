using System;
using NUnit.Framework;
using MovieTicketCsharp.ValueObject;
using MovieTicketCsharp.Domain;

namespace MovieTicketCsharp.Test.FeeModel {
    public class CinemaCitizenFeeModelTest {
        CinemaCitizenFeeModel model;

        [SetUp]
        public void Setup() {
        }

        [Test]
        public void InterfaceTest() {
            Assert.That(model, Is.InstanceOf<IFeeModel>());
        }

        [Test]
        public void 平日20時までは1000円() {

        }

        [Test]
        public void 平日20時以降も1000円() {

        }

        [Test]
        public void 土日20時以降は1000円() {

        }
    }
}

