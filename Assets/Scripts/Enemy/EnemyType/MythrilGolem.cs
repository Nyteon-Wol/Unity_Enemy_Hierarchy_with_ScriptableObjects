using UnityEngine;

public class MythrilGolem : EnemyBase
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Attack();
        }
    }
}
