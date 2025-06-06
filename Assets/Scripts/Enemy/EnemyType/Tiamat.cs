using UnityEngine;

public class Tiamat : EnemyBase
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Attack();
        }
    }
}
