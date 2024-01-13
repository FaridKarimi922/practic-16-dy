namespace tamrin_6_16_dy
{
    public interface IBook
    {
        public string Name { get; set; }
        void SetCount(int count);
        void SetPrice(int price);
    }
}