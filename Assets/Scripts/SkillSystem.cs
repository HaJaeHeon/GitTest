using UnityEngine;

public class SkillSystem : MonoBehaviour
{
    public class Skill
    {
        private string skillName;
        private float skillCooldown;
        private float skillDamage;
        private Sprite skillSprite;
    }

    public class MagicBolt : Skill
    {

    }
}
