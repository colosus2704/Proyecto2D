using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FSM;

[CreateAssetMenu(menuName = "FSM/Player/Action/Shoot")]
public class ShootAction : FSM.Action
{
    public override void Act(Controller controller)
    {
        controller.SetAnimation("idle", false);
        controller.SetAnimation("shoot", true);
        controller.SetAnimation("dash", false);
        controller.SetAnimation("jump", false);
    }
}