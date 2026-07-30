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
            if(enemy_Hp == 0)
            {
                gameObject.SetActive(false);
            }
        }
    }

    public void TakeDamage(int value)
    {
        Hp-=value;
    }
}
