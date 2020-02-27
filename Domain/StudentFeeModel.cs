using MovieTicketCsharp.ValueObject;

namespace MovieTicketCsharp.Domain {
    public class StudentFeeModel : IFeeModel {
        public StudentFeeModel(StudentType studentType) { }
        public int Calculate(DateTimeVo dateTime, AgeVo age) {
            throw new System.NotImplementedException();
        }
    }
}
