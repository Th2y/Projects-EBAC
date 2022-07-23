using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateStart : StateBase
{
    public override void OnStateEnter(Player player)
    {
        player.ChangeToStateStart();
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
