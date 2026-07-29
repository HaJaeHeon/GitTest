using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    private int player_MaxHp;
    private int player_Hp;
    public int Hp
    {
        get => player_Hp;
        private set
        {
            player_Hp = Mathf.Clamp(value, 0, player_MaxHp);
        }
    }
    private int player_MaxExp;
    private int player_Exp;
    public int Exp
    {
        get => player_Exp;
        private set
        {
            player_Exp = Mathf.Clamp(value, 0, player_MaxExp);
        }
    }

    private int player_Level;
    public int Level
    {
        get => player_Level;
        set
        {
            player_Level = Mathf.Clamp(value, 1, 999);
        }
    }

    public int GetHp()
    {
        return Hp;
    }

    public int GetExp()
    {
        return Exp;
    }

    public void LevelUp()
    {
        Level++;
        //나머지 경험치 추가?
    }
    public void TakeDamage(int value)
    {
        Hp -= value;
    }
}
