using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private Button gamePhysButton;
    [SerializeField] private Button configButton;
    [SerializeField] private Button aboutButton;
    [SerializeField] private Button exitButton;
    [SerializeField] private Button closeAboutPanelButton;

    [SerializeField] private GameObject aboutPanel;

    private void Start()
    {
        gamePhysButton.onClick.AddListener(OnClick_Phys);
        configButton.onClick.AddListener(OnClick_Config);
        aboutButton.onClick.AddListener(OnClick_About);
        exitButton.onClick.AddListener(OnClick_Exit);
        closeAboutPanelButton.onClick.AddListener(OnClick_AboutClose);
    }

    private void OnClick_Phys()
    {
        SceneManager.LoadScene(1);
    }

    private void OnClick_Config()
    {
        //Конфигурация
    }

    private void OnClick_About()
    {
        aboutPanel.SetActive(true);
    }
    
    private void OnClick_AboutClose()
    {
        aboutPanel.SetActive(false);
    }

    private void OnClick_Exit()
    {
        Application.Quit();
    }
}
