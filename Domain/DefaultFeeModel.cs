using MovieTicketCsharp.ValueObject;

namespace MovieTicketCsharp.Domain {
    public class DefaultFeeModel :IFeeModel {
        public DefaultFeeModel(int age) {

        }
        public int Calculate(DateTimeVo dateTime) {
            throw new System.NotImplementedException();
        }
    }
}
