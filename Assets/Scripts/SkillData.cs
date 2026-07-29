using UnityEngine;


[CreateAssetMenu(menuName ="Game Data/Skill Data")]
public class SkillData : ScriptableObject
{
    public int skillId;
    public int skillLevel;
    public string skillName;
    public float skillCooldown;
    public float skillDamage;
    public Sprite skillSprite;
}
