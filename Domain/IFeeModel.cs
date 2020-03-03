using MovieTicketCsharp.ValueObject;

namespace MovieTicketCsharp.Domain {
    public interface IFeeModel {
        int Calculate(DateTimeVo dateTime);
    }
}
