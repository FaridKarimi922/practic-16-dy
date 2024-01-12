namespace tamrin_6_16_dy
{
    public interface IBook
    {
        int Count { get; }
        string Name { get; set; }
        int Price { get; }

        void AddCount(int count);
        void AddPrice(int price);
    }
}