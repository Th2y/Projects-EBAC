using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum States
{
    START,
    ALIVE,
    DIE
}

public class StateMachine : MonoBehaviour
{
    private Dictionary<States, StateBase> states;
    private StateBase actualState;

    [SerializeField] private Player player;

    private void Awake()
    {
        states = new Dictionary<States, StateBase>();
        states.Add(States.START, new StateStart());
        states.Add(States.ALIVE, new StateAlive());
        states.Add(States.DIE, new StateDie());
        SwitchState(States.START);
    }

    public void SwitchState(States state)
    {
        if (actualState != null) actualState.OnStateExit();

        actualState = states[state];
        actualState.OnStateEnter(player);
    }

    private void Update()
    {
        if (actualState != null) actualState.OnStateStay();
    }
}
