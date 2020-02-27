﻿using System;
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
    }
}
