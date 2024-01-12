namespace tamrin_9_16_dy
{
    public interface IFood
    {
        string Name { get; set; }
        int Price { get; }
        int TimeGEtReady { get; }

        void SetPrice(int price);
        void SetTimeGetReady(int timeGetReady);
    }
}