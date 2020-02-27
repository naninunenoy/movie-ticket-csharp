using System;

namespace MovieTicketCsharp.ValueObject {
    public readonly struct AgeVo : IValueObject {
        public readonly int Value;

        public AgeVo(int value) {
            if (value < 0) {
                throw new ArgumentException("not negative");
            }
            Value = value;
        }
    }
}
