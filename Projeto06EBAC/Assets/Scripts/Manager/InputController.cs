using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private StateMachine stateMachine;

    private States actualState = States.START;

    void Update()
    {
        if(actualState == States.START)
        {
            if (Input.GetMouseButtonDown(0))
            {
                ChangeState(States.ALIVE);
            }
        }

        if (actualState != States.ALIVE) return;

        if (Input.GetKeyDown(KeyCode.P))
        {
            ChangeState(States.DIE);
            return;
        }

        if (Input.GetMouseButtonDown(1))
        {
            player.WhenShooting();
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            player.MoveToLeft();
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            player.MoveToRight();
        }
    }

    public void ChangeState(States state)
    {
        stateMachine.SwitchState(state);
        actualState = state;
    }
}
