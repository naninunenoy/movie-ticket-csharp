using MovieTicketCsharp.ValueObject;

namespace MovieTicketCsharp.Domain {
    public class BabyFeeModel : IFeeModel {
        public int Calculate(DateTimeVo dateTime) {
            // 常に無料
            return 0;
        }
    }
}
