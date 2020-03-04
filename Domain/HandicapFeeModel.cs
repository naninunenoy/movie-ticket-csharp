using MovieTicketCsharp.ValueObject;

namespace MovieTicketCsharp.Domain {
    public class HandicapFeeModel : IFeeModel {
        readonly FeeCalculator calculator;

        public HandicapFeeModel(bool isMoreThan18Years) {
            if (isMoreThan18Years) {
                calculator = new FeeCalculator(1000,1000,
                    1000,1000,1000);
            } else {
                calculator = new FeeCalculator(900,900,
                    900,900,900);
            }
        }
        public int Calculate(DateTimeVo dateTime) => calculator.CalcByDateTime(dateTime);
    }
}
