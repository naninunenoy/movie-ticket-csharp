using MovieTicketCsharp.ValueObject;

namespace MovieTicketCsharp.Domain {
    public class StudentFeeModel : IFeeModel {
        readonly FeeCalculator calculator;

        public StudentFeeModel(StudentType studentType) {
            if (studentType == StudentType.University ||
                studentType == StudentType.VocationalSchool) {
                calculator = new FeeCalculator(1500,1300,
                    1500,1300,1100);
            } else {
                calculator = new FeeCalculator(1000,1000,
                    1000,1000,1000);
            }
        }

        public int Calculate(DateTimeVo dateTime) => calculator.CalcByDateTime(dateTime);
    }
}
