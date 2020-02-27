using System;

namespace MovieTicketCsharp.ValueObject {
    public readonly struct DayOfWeekVo : IValueObject {
        public readonly int Value;

        public DayOfWeekVo(int value) {
            if (value < 0 || 6 < value) {
                throw new ArgumentException("not in range 0-6");
            }
            Value = value;
        }

        public bool IsWeekendDays() => Value == 0 || Value == 6;
        public bool IsWeekDays() => !IsWeekendDays();
    }
}
