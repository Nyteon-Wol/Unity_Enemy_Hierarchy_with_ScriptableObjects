using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public EnemyObject enemySettings;

    // campos para informa��es tipo string
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

    [SerializeField]
    private Renderer render;
    private Color originalColor;

    private void Awake()
    {
        // Informa��es b�sicas
        Name = enemySettings.name;
        AttackName = enemySettings.AttackName;
        IsRanged = enemySettings.IsRanged;
        IsFlying = enemySettings.IsFlying;
        HP = enemySettings.HP;
        Strenght = enemySettings.Strenght;
        Speed = enemySettings.Speed;

        // salva a cor original do inimigo
        originalColor = render.material.color;
    }


    // Cria um m�todo para morte do inimigo
    public virtual void Die()
    {
        Debug.Log(Name + " Morreu!");
        Destroy(gameObject);
    }

    // Cria um m�todo para atacar
    public virtual void Attack()
    {
        Debug.Log(Name + " atacou com " + AttackName + " e causou " 
            + Strenght + " de dano");
        Damage(Strenght);
    }

    // M�todo para receber dano, reduz o hp atual pelo dano sofrito, e 
    // caso chegue a zero, o m�todo Die() � chamado.
    // � um "public virtual" para que os filhos possam sobrescrever
    public virtual void Damage(float damage)
    {
        // Chama o m�todo de feedback visual
        StartCoroutine(FlashColor());
        HP -= damage;
        // retorna o hp atual do inimigo
        Debug.Log(Name + " Possui " + HP + " pontos de vida restantes");
        if (HP <= 0)
        {
            Die();
        }
    }

    protected virtual System.Collections.IEnumerator FlashColor()
    {
        // M�todo para feedback visual no inimigo quando ele recebe dano
        render.material.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        render.material.color = originalColor;
    }

}
