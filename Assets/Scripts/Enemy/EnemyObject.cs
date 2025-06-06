using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Cria uma referencia como asset
[CreateAssetMenu(fileName = "enemySettings", menuName = "Enemy/new Enemy")]
public class EnemyObject : ScriptableObject
{
    // campos para informações tipo string
    [Header("Basic string infos")]
    public string Name;
    public string AttackName;

    // Campos para o tipo de ataque
    [Header("Attack Type")]
    public bool IsRanged;

    // Campos para o tipo de inimigo
    [Header("Enemy Type")]
    public bool IsFlying;

    // Campo para os status base
    [Header("Basic Stats")]
    public float HP;
    public int Strenght;
    public float Speed;
}
