using MovieTicketCsharp.ValueObject;

namespace MovieTicketCsharp.Domain {
    public class CinemaCitizenFeeModel : IFeeModel {
        readonly FeeCalculator calculator;
        public CinemaCitizenFeeModel(int age) {
            if (age < 60) {
                calculator = new FeeCalculator(1000, 1000,
                    1300, 1000, 1100);
            } else {
                calculator = new FeeCalculator(1000, 1000,
                    1000, 1000, 1000);
            }
        }

        public int Calculate(DateTimeVo dateTime) => calculator.CalcByDateTime(dateTime);
    }
}
