using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PursueState : BaseState
{
    private DumbTank enemyTank;

    public PursueState(DumbTank enemyTank)
    {
        this.enemyTank = enemyTank;
    }

    public override Type StateEnter()
    {
        return null;
    }

    public override Type StateExit()
    {
        return null;
    }

    public override Type StateUpdate()
    {
        // If enemy tank is not visible, switch to PatrolState
        if (Vector3.Distance(enemyTank.transform.position, enemyTank.targetGameObject.transform.position < 1.0f))
        {
            return typeof(AttackState);
        }
        // If enemy tank is within firing range, switch to AttackState
        else if (Vector3.Distance(enemyTank.transform.position, enemyTank.targetGameObject.transform.position) > enemyTank.pursueRange)
        {
            return typeof(PatrolState);
        }
        else
        {
            return null;
        }

    }
}
