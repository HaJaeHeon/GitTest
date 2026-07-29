using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] private float player_MaxHp;
    [SerializeField] private float player_Hp;
    public event Action<float> OnChangedHp;
    public event Action<float> OnChangedExp;
    [SerializeField] private float player_Level;
    [SerializeField] private InputActionReference getExpAction;
    
    public float Hp
    {
        get => player_Hp;
        private set
        {
            player_Hp = Mathf.Clamp(value, 0, player_MaxHp);
        }
    }
    [SerializeField] private float player_MaxExp;
    [SerializeField] private float player_Exp;
    public float Exp
    {
        get => player_Exp;
        private set
        {
            player_Exp = value;

            if(player_Exp >= player_MaxExp)
            {
                player_Exp -= player_MaxExp;
                player_Level++;
            }
        }
    }




    private void OnEnable()
    {
        getExpAction.action.performed += TestGetExp;
    }

    private void Start()
    {
        Hp = 100;
        player_Hp = 100;
        TakeDamage(0);
        GetExp(0);
    }

    public float GetHp()
    {
        return Hp;
    }

    public float GetExp()
    {
        return Exp;
    }

    public void TakeDamage(float value)
    {
        if(Hp <= 0)
        {
            return;
        }
        Hp -= value;
        OnChangedHp?.Invoke(Hp);
    }
    public void Heal(float value)
    {
        Hp += value;
        OnChangedHp?.Invoke(Hp);
    }

    public void GetExp(float value)
    {
        Exp += value;
        OnChangedExp?.Invoke(Exp);
    }

    public void TestGetExp(InputAction.CallbackContext obj)
    {
        GetExp(11);
    }
}
