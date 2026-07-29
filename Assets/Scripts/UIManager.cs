using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] PlayerInfo playerInfo;
    
    [SerializeField] private Slider hpSlider;
    [SerializeField] private TMP_Text hpText;
    [SerializeField] private Slider expSlider;
    [SerializeField] private TMP_Text expText;
    StringBuilder sb = new StringBuilder();


    private void OnEnable()
    {
        playerInfo.OnChangedHp += ChangeHpBarHandler;
        playerInfo.OnChangedExp += ChangeExpBarHandler;
    }

    public void ChangeHpBarHandler(float value)
    {
        hpSlider.value = value;
        //Debug.Log($"Hp : {value}");
        sb.Clear();
        sb.Append(value);
        hpText.text = sb.ToString();
    }

    public void ChangeExpBarHandler(float value)
    {
        expSlider.value = value;
        Debug.Log($"Exp : {value}");
        sb.Clear();
        sb.Append(value);
        expText.text = sb.ToString();
    }
}
