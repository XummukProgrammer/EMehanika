public class EMMeatResource
{
    public int Meat { get; private set; }

    public void AddMeat(int meat)
    {
        int prevMeat = Meat;
        Meat += meat;

        EMEvents.MeatResourceChanged?.Invoke(prevMeat, Meat);
    }
}
