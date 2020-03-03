﻿using System;
using NUnit.Framework;
using MovieTicketCsharp.ValueObject;
using MovieTicketCsharp.Domain;

namespace MovieTicketCsharp.Test.FeeModel {
    public class StudentFeeModelTest_VocationalSchool {
        StudentFeeModel model;
        [SetUp]
        public void Setup() {
            model = new StudentFeeModel(StudentType.VocationalSchool);
        }

        [Test]
        public void InterfaceTest() {
            Assert.That(model, Is.InstanceOf<IFeeModel>());
        }

        // 学生であれば年齢は関係ない想定
        // 大学生と一緒の値段

        [TestCase(19, 1500)]
        [TestCase(20, 1300)]
        [TestCase(4, 1300)]
        [TestCase(5, 1500)]
        public void 映画の日以外(int hour, int price) {
            Assert.That(
                model.Calculate(TestDateTimeVo.Sunday.SetHour(hour),  TestAgeVo.AgeOf(0)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Monday.SetHour(hour),  TestAgeVo.AgeOf(0)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Tuesday.SetHour(hour),  TestAgeVo.AgeOf(0)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Wednesday.SetHour(hour),  TestAgeVo.AgeOf(0)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Thursday.SetHour(hour),  TestAgeVo.AgeOf(0)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Friday.SetHour(hour),  TestAgeVo.AgeOf(0)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.Saturday.SetHour(hour),  TestAgeVo.AgeOf(0)),
                Is.EqualTo(price)
            );
        }

        [TestCase(1100)]
        public void 映画の日(int price) {
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Sunday,  TestAgeVo.AgeOf(0)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Monday,  TestAgeVo.AgeOf(0)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Tuesday,  TestAgeVo.AgeOf(0)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Wednesday,  TestAgeVo.AgeOf(0)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Thursday,  TestAgeVo.AgeOf(0)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Friday,  TestAgeVo.AgeOf(0)),
                Is.EqualTo(price)
            );
            Assert.That(
                model.Calculate(TestDateTimeVo.FirstDay.Saturday,  TestAgeVo.AgeOf(0)),
                Is.EqualTo(price)
            );
        }
    }
}