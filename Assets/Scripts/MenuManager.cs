using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class MenuManager : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TMP_Text bestScoreText;
    void Start()
    {
        if (GameManager.Instance != null && GameManager.Instance.bestScore > 0)
        {
            bestScoreText.text = $"Best Score: {GameManager.Instance.bestPlayerName} : {GameManager.Instance.bestScore}";
        }
    }

    void Update()
    {
        
    }

    public void StartButtonClick()
    {
        GameManager.Instance.bestPlayerName = nameInput.text;
        SceneManager.LoadScene(1);
    }

    public void QuitButtonClick()
    {
        Application.Quit();
    }
}
