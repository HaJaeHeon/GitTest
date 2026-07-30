using UnityEngine;

public class PlayerSkill : MonoBehaviour
{
    [SerializeField] private PlayerSkill_Aura aura;
    [SerializeField] private PlayerSkill_FireBlast fireBlast;
    [SerializeField] private PlayerSkill_MagicMissle magicMissle;
    [SerializeField] private PlayerSkill_Saw saw;
    [SerializeField] private PlayerSkill_SpikeBall spikeBall;

    [SerializeField] private float detectEnemySize = 5f;
    [SerializeField] private LayerMask enemyLayerMask;

    private void Awake()
    {
        aura = GetComponent<PlayerSkill_Aura>();
        fireBlast = GetComponent<PlayerSkill_FireBlast>();
        magicMissle = GetComponent<PlayerSkill_MagicMissle>();
        saw = GetComponent<PlayerSkill_Saw>();
        spikeBall = GetComponent<PlayerSkill_SpikeBall>();
    }

    private void Update()
    {
        CastingAura();
        CastingFireBlast();
        CastingMagicMissile();
        CastingSaw();
        CastingSpikeBall();
    }

    private Vector2 CalcTargetPosition()
    {
        Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, detectEnemySize, enemyLayerMask);

        if (hits.Length == 0)
            return Vector2.zero;

        float distance = float.MaxValue;
        GameObject nearEnemy = null;
        foreach (Collider2D hit in hits)
        {
            float enemyDistance = (hit.transform.position - transform.position).sqrMagnitude;
            if ( distance > enemyDistance)
            {
                distance = enemyDistance;
                nearEnemy = hit.gameObject;
            }
        }
        if( nearEnemy == null )
        {
            return Vector2.zero;
        }

        Vector2 direction = (nearEnemy.transform.position - transform.position).normalized;
        return direction;
    }

    private void CastingAura()
    {
        aura.CastSkill(gameObject, Vector2.zero);
    }
    private void CastingFireBlast()
    {
        fireBlast.CastSkill(gameObject, CalcTargetPosition());
    }
    private void CastingMagicMissile()
    {
        magicMissle.CastSkill(gameObject, CalcTargetPosition());
        Debug.Log(CalcTargetPosition());
    }
    private void CastingSaw()
    {
        saw.CastSkill(gameObject, CalcTargetPosition());
    }
    private void CastingSpikeBall()
    {
        spikeBall.CastSkill(gameObject, CalcTargetPosition());
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.rebeccaPurple;
        Gizmos.DrawWireSphere(transform.position, detectEnemySize);
    }
}
