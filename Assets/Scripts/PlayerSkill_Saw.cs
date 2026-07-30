using UnityEngine;

public class PlayerSkill_Saw : Skill
{
    [SerializeField] private GameObject skillPrefab;
    [SerializeField] private float skillTimer;    
    public override void CastSkill(GameObject player)
    {
        skillTimer += Time.deltaTime;
        if (skillData.skillLevel >= 1 && skillTimer > skillData.skillCooldown)
        {
            skillTimer = 0f;
            GameObject skill = Instantiate(skillPrefab);
            skill.transform.parent = player.transform;
        }
    }
}
