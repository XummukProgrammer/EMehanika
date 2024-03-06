public class EMShopItem
{
    public int Count { get; private set; }
    public EMShopData Data { get; private set; }

    public int Cost => Data.Cost + Data.ExtraCost * Count;
    public bool IsMaxed => Count >= Data.MaxCount;

    public EMShopItem(EMShopData data)
    {
        Data = data;

        Count = 0;
    }

    public void OnBuy()
    {
        ++Count;
    }

    public void Reset()
    {
        Count = 0;
    }
}
