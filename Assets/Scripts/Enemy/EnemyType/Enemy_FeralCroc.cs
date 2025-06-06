using UnityEditor.Playables;
using UnityEngine;
using UnityEngine.InputSystem;

public class Enemy_FeralCroc : EnemyBase
{

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Attack();
        }
    }
}
