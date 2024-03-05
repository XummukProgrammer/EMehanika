public class EMBoostrap
{
    public void Setup(EMComponents components, EMGlobalData globalData)
    {
        components.StatesManager.AddState(EMStateType.Level, new EMLevelState());
        components.StatesManager.SetState(EMStateType.Level);
    }
}
