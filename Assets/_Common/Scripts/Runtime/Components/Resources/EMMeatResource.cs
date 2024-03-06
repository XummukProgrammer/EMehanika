public class EMMeatResource
{
    public int Meat { get; private set; }

    public void AddMeat(int meat)
    {
        int prevMeat = Meat;
        Meat += meat;

        EMEvents.MeatResourceChanged?.Invoke(prevMeat, Meat);
    }

    public void TakeMeat(int meat)
    {
        int prevMeat = Meat;
        Meat -= meat;

        if (Meat < 0)
        {
            Meat = 0;
        }

        EMEvents.MeatResourceChanged?.Invoke(prevMeat, Meat);
    }

    public void Reset()
    {
        Meat = 0;

        EMEvents.MeatResourceChanged?.Invoke(0, 0);
    }
}
