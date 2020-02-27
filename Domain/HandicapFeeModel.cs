using MovieTicketCsharp.ValueObject;

namespace MovieTicketCsharp.Domain {
    public class HandicapFeeModel : IFeeModel {
        public HandicapFeeModel(bool isMoreThan18Years) { }
        public int Calculate(DateTimeVo dateTime, AgeVo age) {
            throw new System.NotImplementedException();
        }
    }
}
