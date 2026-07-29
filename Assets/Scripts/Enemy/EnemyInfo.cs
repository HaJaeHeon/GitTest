using UnityEngine;

public class EnemyInfo : MonoBehaviour
{
    private int enemy_MaxHp;
    private int enemy_Hp;
    public int Hp
    {
        get => enemy_Hp;
        private set
        {
            enemy_Hp = Mathf.Clamp(value, 0, enemy_MaxHp);
        }
    }

    public void TakeDamage(int value)
    {
        Hp-=value;
    }
}
