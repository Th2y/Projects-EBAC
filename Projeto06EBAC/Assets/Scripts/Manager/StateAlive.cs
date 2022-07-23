using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateAlive : StateBase
{
    public override void OnStateEnter(Player player)
    {
        player.ChangeToStateAlive();
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
