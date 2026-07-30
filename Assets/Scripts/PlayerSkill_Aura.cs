using UnityEngine;

public class PlayerSkill_Aura : Skill
{
    [SerializeField] private GameObject skillPrefab;
    [SerializeField] private bool isActive;
    
    public override void CastSkill(GameObject player)
    {
        if (skillData.skillLevel >= 1 && !isActive)
        {
            isActive = true;
            GameObject skill = Instantiate(skillPrefab);
            skill.transform.parent = player.transform;
            skill.transform.position = Vector3.zero;
        }
    }
}
