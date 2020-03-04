using System;
using MovieTicketCsharp.ValueObject;

namespace MovieTicketCsharp.Domain {
    public class FeeCalculator {
        readonly int weekdayFee;
        readonly int weekdayNightFee;
        readonly int holidayFee;
        readonly int holidayNightFee;
        readonly int moviesDayFee;

        public FeeCalculator(int weekdayFee, int weekdayNightFee,
            int holidayFee, int holidayNightFee, int moviesDayFee) {
            this.weekdayFee = weekdayFee;
            this.weekdayNightFee = weekdayNightFee;
            this.holidayFee = holidayFee;
            this.holidayNightFee = holidayNightFee;
            this.moviesDayFee = moviesDayFee;
        }

        public int CalcByDateTime(DateTimeVo dt) {
            var weekday = dt.Time.IsLate() ? weekdayNightFee : weekdayFee;
            var holiday = dt.Time.IsLate() ? holidayNightFee : holidayFee;
            var notMovieDay = dt.DayOfWeek.IsWeekendDays() ? holiday : weekday;
            // 映画の日が通常料金より高くなる場合は安い方を出力
            return dt.Date.IsMovieDay() ? Math.Min(moviesDayFee, notMovieDay) : notMovieDay;
        }
    }
}
