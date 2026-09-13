using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public string levelSceneName;
    public RectTransform savePanel;
    public Button selectSaveBtn;

    void Start()
    {
        // TODO loop saves
        Button btn = Instantiate(selectSaveBtn, savePanel);
        btn.onClick.AddListener(LoadSave);
    }
    
    public void NewGame()
    {
        SceneManager.LoadScene(levelSceneName);
    }
    
    public void LoadSave()
    {
        // TODO
    }
}
