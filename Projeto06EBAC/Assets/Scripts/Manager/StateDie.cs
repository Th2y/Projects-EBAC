using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateDie : StateBase
{
    public override void OnStateEnter(Player player)
    {
        player.ChangeToStateDie();
        base.OnStateEnter(player);
    }

    public override void OnStateStay()
    {
        base.OnStateStay();
    }

    public override void OnStateExit()
    {
        base.OnStateExit();
    }
}
