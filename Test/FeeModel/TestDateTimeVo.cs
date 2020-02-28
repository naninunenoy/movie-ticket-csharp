using System;
using MovieTicketCsharp.ValueObject;

namespace MovieTicketCsharp.Test.FeeModel {
    public static class TestDateTimeVo {
        static readonly DateTime basis = new DateTime(2020,2,2);
        public static DateTimeVo Sunday => new DateTimeVo(basis);
        public static DateTimeVo Monday => new DateTimeVo(basis.AddDays(1));
        public static DateTimeVo Tuesday => new DateTimeVo(basis.AddDays(2));
        public static DateTimeVo Wednesday => new DateTimeVo(basis.AddDays(3));
        public static DateTimeVo Thursday => new DateTimeVo(basis.AddDays(4));
        public static DateTimeVo Friday => new DateTimeVo(basis.AddDays(5));
        public static DateTimeVo Saturday => new DateTimeVo(basis.AddDays(6));

        public static DateTimeVo SetDay(this DateTimeVo dt, int day) {
            return new DateTimeVo(new DateTime(dt.Date.Year, dt.Date.Month, day));
        }

        public static DateTimeVo SetHour(this DateTimeVo dt, int hour) {
            return new DateTimeVo(new DateTime(dt.Date.Year, dt.Date.Month, dt.Date.Day, hour, 0, 0));
        }
    }
}
