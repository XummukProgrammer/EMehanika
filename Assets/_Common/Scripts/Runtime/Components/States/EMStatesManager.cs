using System.Collections.Generic;

public class EMStatesManager
{
    private Dictionary<EMStateType, IEMState> _states = new();
    private IEMState _currentState;
    private IEMState _newState;

    public EMStateType CurrentStateType { get; private set; }

    public void AddState(EMStateType type, IEMState state)
    {
        _states.Add(type, state);
    }

    public IEMState GetState(EMStateType type)
    {
        return _states[type];
    }

    public void SetState(EMStateType type)
    {
        _newState = GetState(type);

        if (_newState == null)
        {
            EMDebugHelper.PrintError("EMStatesManager", $"The state with the ID: '{type}' was not found.");
        }
        else
        {
            CurrentStateType = type;
        }
    }

    public void OnInit()
    {
        foreach (var state in _states.Values)
        {
            state.OnInit();
        }
    }

    public void OnDeinit()
    {
        foreach (var state in _states.Values)
        {
            state.OnDeinit();
        }
    }

    public void OnUpdate()
    {
        if (_newState != null)
        {
            if (_currentState != null)
            {
                _currentState.OnExit();
            }

            _currentState = _newState;
            _newState = null;

            _currentState.OnEnter();
            return;
        }

        if (_currentState != null)
        {
            _currentState.OnUpdate();
        }
    }
}
