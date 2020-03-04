using MovieTicketCsharp.ValueObject;

namespace MovieTicketCsharp.Domain {
    public class DefaultFeeModel :IFeeModel {
        readonly FeeCalculator calculator;
        public DefaultFeeModel(int age) {
            if (age < 70) {
                calculator = new FeeCalculator(1800, 1300,
                    1800, 1300, 1100);
            } else {
                calculator = new FeeCalculator(1100, 1100,
                    1100, 1100, 1100);
            }
        }

        public int Calculate(DateTimeVo dateTime) => calculator.CalcByDateTime(dateTime);
    }
}
