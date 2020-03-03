﻿using System;
using NUnit.Framework;
using MovieTicketCsharp.ValueObject;
using MovieTicketCsharp.Domain;

namespace MovieTicketCsharp.Test.FeeModel {
    public class HandicapFeeModelTest_LessThan18Years {
        HandicapFeeModel model;
        [SetUp]
        public void Setup() {
            model = new HandicapFeeModel(false);
        }

        [Test]
        public void InterfaceTest() {
            Assert.That(model, Is.InstanceOf<IFeeModel>());
        }

        // 学生以下なら年齢は無関係

        [TestCase(19, 900)]
        [TestCase(20, 900)]
        [TestCase(4, 900)]
        [TestCase(5, 900)]
        public void 映画の日以外(int hour, int price) {
            Assert.That(
                model.Calculate(TestDateTimeVo.Sunday.SetHour(hour)),
                Is.EqualTo(price)
            );
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
            Assert.That(
                model.Calculate(TestDateTimeVo.Saturday.SetHour(hour)),
                Is.EqualTo(price)
            );
        }

        [TestCase(900)]
        public void 映画の日(int price) {
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Sunday),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Monday),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Tuesday),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Wednesday),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Thursday),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Friday),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Saturday),
                Is.EqualTo(price)
            );
        }
    }
}
