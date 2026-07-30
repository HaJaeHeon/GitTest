using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    EnemyInfo info;
    float hitTimer;
    [SerializeField] float damageDuration = 1f;

    private void Awake()
    {
        info = GetComponent<EnemyInfo>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Skill"))
        {
            Debug.Log("TriggerStay");
            info.TakeDamage(collision.gameObject.GetComponent<SkillData>().skillDamage);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        hitTimer += Time.deltaTime;
        if(collision.CompareTag("FireSkill") && hitTimer > damageDuration)
        {
            hitTimer = 0;
            Debug.Log("FireSkill");
            info.TakeDamage(collision.gameObject.GetComponent<SkillData>().skillDamage);
        }
    }
}
