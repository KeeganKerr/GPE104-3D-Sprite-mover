using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathRecenter : Death
{   // Recenters the game object on death
    public override void IsDead()
    {   // returns the pawn to the center
        transform.position = Vector3.zero;

    }
}
