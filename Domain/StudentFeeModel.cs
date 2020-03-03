using MovieTicketCsharp.ValueObject;

namespace MovieTicketCsharp.Domain {
    public class StudentFeeModel : IFeeModel {
        public StudentFeeModel(StudentType studentType) { }
        public int Calculate(DateTimeVo dateTime) {
            throw new System.NotImplementedException();
        }
    }
}
