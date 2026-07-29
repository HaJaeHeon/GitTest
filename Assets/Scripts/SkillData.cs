using UnityEngine;


[CreateAssetMenu(menuName ="Game Data/Skill Data")]
public class SkillData : ScriptableObject
{
    public int skillId;
    public string skillName;
    public float skillCooldown;
    public float skillDamage;
    public Sprite skillSprite;
}
