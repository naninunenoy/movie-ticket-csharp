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

        public static DateTimeVo SetHour(this DateTimeVo dt, int hour) {
            return new DateTimeVo(new DateTime(dt.Date.Year, dt.Date.Month, dt.Date.Day, hour, 0, 0));
        }

        public static class FirstDay {
            public static DateTimeVo Sunday => new DateTimeVo(new DateTime(2020, 3, 1));
            public static DateTimeVo Monday  => new DateTimeVo(new DateTime(2020, 6, 1));
            public static DateTimeVo Tuesday  => new DateTimeVo(new DateTime(2020, 9, 1));
            public static DateTimeVo Wednesday => new DateTimeVo(new DateTime(2020, 1, 1));
            public static DateTimeVo Thursday  => new DateTimeVo(new DateTime(2020, 10, 1));
            public static DateTimeVo Friday => new DateTimeVo(new DateTime(2020, 5, 1));
            public static DateTimeVo Saturday  => new DateTimeVo(new DateTime(2020, 2, 1));
        }
    }
}
