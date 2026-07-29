using UnityEngine;
using UnityEngine.UI;

public class StartSceneUI : MonoBehaviour
{
    [SerializeField] Button PlayButton;
    [SerializeField] Button QuitButton;

    private void Start()
    {
        PlayButton.onClick.AddListener(SceneLoader.instance.LoadPlayScene);
        QuitButton.onClick.AddListener(SceneLoader.instance.QuitGame);
    }
    private void OnDisable()
    {
        PlayButton.onClick.RemoveAllListeners();
        QuitButton.onClick.RemoveAllListeners();
    }
}
