using MovieTicketCsharp.ValueObject;

namespace MovieTicketCsharp.Test.FeeModel {
    public static class TestAgeVo {
        public static AgeVo Age59 => new AgeVo(50);
        public static AgeVo Age60 => new AgeVo(60);
        public static AgeVo Age69 => new AgeVo(69);
        public static AgeVo Age70 => new AgeVo(70);
        public static AgeVo AgeOf(int of) => new AgeVo(of);
    }
}
