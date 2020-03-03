using MovieTicketCsharp.ValueObject;

namespace MovieTicketCsharp.Domain {
    public class CinemaCitizenFeeModel : IFeeModel {
        public CinemaCitizenFeeModel(int age) {

        }
        public int Calculate(DateTimeVo dateTime, AgeVo age) {
            throw new System.NotImplementedException();
        }
    }
}
