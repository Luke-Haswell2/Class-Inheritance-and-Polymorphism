using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcScript : EnemyBase
{
    void Start()
    {
        AttackPlayer();
    }

    public override void AttackPlayer()
    {
        print("Orc is attacking player");
    }
}
