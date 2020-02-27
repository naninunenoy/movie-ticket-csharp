using System;

namespace MovieTicketCsharp.ValueObject {
    public readonly struct DateVo : IValueObject {
        public readonly int Year;
        public readonly int Month;
        public readonly int Day;

        public DateVo(int year, int month, int day) {
            if (year < 0) {
                throw new ArgumentException("year is not negative");
            }
            if (month < 0 || 12 < month) {
                throw new ArgumentException("not in range 1-12");
            }
            if (day < 0 || 31 < day) {
                throw new ArgumentException("not in range 1-31");
            }
            Year = year;
            Month = month;
            Day = day;
        }

        public bool IsFirstDay() => Day == 1;
    }
}
