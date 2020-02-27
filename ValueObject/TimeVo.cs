using System;

namespace MovieTicketCsharp.ValueObject {

    public readonly struct TimeVo : IValueObject {
        public readonly int Hour;

        public TimeVo(int hour) {
            if (hour < 0 || 23 < hour) {
                throw new ArgumentException("not in range 0-23");
            }
            Hour = hour;
        }

        public bool IsLate() {
            if (Hour >= 20) {
                // 20時以降はレイトショー
                return true;
            }
            if (Hour < 5) {
                // 深夜(5時までとする)もレイトショーとしておく
                return true;
            }
            return false;
        }
    }
}
