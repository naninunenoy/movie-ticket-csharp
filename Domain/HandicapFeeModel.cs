using MovieTicketCsharp.ValueObject;

namespace MovieTicketCsharp.Domain {
    public class HandicapFeeModel : IFeeModel {
        public HandicapFeeModel(bool isMoreThan18Years) { }
        public int Calculate(DateTimeVo dateTime) {
            throw new System.NotImplementedException();
        }
    }
}
