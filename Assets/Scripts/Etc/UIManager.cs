using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private PlayerInfo playerInfo;
    [SerializeField] private GameObject SettingsPanel;
    
    [SerializeField] private Slider hpSlider;
    [SerializeField] private TMP_Text hpText;
    [SerializeField] private Slider expSlider;
    [SerializeField] private TMP_Text expText;
    StringBuilder sb = new StringBuilder();

    [SerializeField] private Button TitleButton;
    [SerializeField] private Button QuitButton;

    [SerializeField] InputActionReference SettingAction;


    private void OnEnable()
    {
        playerInfo.OnChangedHp += ChangeHpBarHandler;
        playerInfo.OnChangedExp += ChangeExpBarHandler;
        SettingAction.action.performed += SettingPanelToggled;

        TitleButton.onClick.AddListener(SceneLoader.instance.LoadStartScene);
        QuitButton.onClick.AddListener(SceneLoader.instance.QuitGame);
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

    public void SettingPanelToggled(InputAction.CallbackContext obj)
    {
        SettingsPanel.SetActive(!SettingsPanel.activeSelf);
        if (SettingsPanel.activeSelf)
            Time.timeScale = 0f;
        else
            Time.timeScale = 1f;
    }
}
