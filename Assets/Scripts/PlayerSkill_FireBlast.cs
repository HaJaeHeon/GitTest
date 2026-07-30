using UnityEngine;

public class PlayerSkill_FireBlast : Skill
{
    [SerializeField] private GameObject skillPrefab;
    [SerializeField] private float skillTimer;
    [SerializeField] private float skillSpeed;
    [SerializeField] private float duration;
    public override void CastSkill(GameObject player, Vector2 direction)
    {
        if (direction == Vector2.zero)
            return;

        skillTimer += Time.deltaTime;
        if (skillData.skillLevel >= 1 && skillTimer > skillData.skillCooldown)
        {
            skillTimer = 0f;
            GameObject skill = Instantiate(skillPrefab);
            skill.transform.position = player.transform.position;
            skill.transform.LookAt(direction);
            Destroy(skill, duration);
        }
    }
}
