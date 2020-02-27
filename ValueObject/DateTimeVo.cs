using System;

namespace MovieTicketCsharp.ValueObject {
    public readonly struct DateTimeVo : IValueObject {
        public readonly DateVo Date;
        public readonly DayOfWeekVo DayOfWeek;
        public readonly TimeVo Time;

        public DateTimeVo(DateTime dateTime) {
            var d = dateTime;
            try {
                Date = new DateVo(d.Year, d.Month, d.Day);
            } catch (ArgumentException) {
                throw;
            }
            try {
                DayOfWeek = new DayOfWeekVo((int)d.DayOfWeek);
            } catch (ArgumentException) {
                throw;
            }
            try {
                Time = new TimeVo(d.Hour);
            } catch (ArgumentException) {
                throw;
            }
        }
    }
}
