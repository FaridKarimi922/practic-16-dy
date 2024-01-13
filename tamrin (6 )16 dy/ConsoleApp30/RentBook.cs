namespace tamrin_6_16_dy
{
    public class RentBook : IBook
    {
        public RentBook(string name, int price, int count)
        {
            Name = name;
            Price = price;
            Count = count;

        }
        public string Name { get; set; }
        public int Price { get; private set; }
        public int Count { get; private set; }

        public void SetCount(int count)
        {
            if (count > 200)
            {
                throw new Exception("count nemitone bishtar az 200 bashad!!!");
            }
        }
        public void SetPrice(int price)
        {
            if (price > 500)
            {
                throw new Exception("price nemitone bishtar az 500 bashad!!!");
            }
        }
    }
}
