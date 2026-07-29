using UnityEngine;

public abstract class Skill : MonoBehaviour
{
    public SkillData skillData;
    public abstract void CastSkill(GameObject player);
}
