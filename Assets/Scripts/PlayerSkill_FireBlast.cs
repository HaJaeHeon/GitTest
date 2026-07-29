using UnityEngine;

public class PlayerSkill_FireBlast : Skill
{
    [SerializeField] private GameObject skillPrefab;
    [SerializeField] private float skillTimer;    
    public override void CastSkill(GameObject player)
    {
        if (skillData.skillLevel >= 1 && skillTimer > skillData.skillCooldown)
        {
            skillTimer = 0f;
            GameObject skill = Instantiate(skillPrefab);
            skill.transform.parent = player.transform;
        }
    }
}
