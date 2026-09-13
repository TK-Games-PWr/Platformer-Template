using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;
    
    public int coinsCollected = 0;
    public TextMeshProUGUI coinText;
    
    public AudioSource coinPickupSound;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    private void Start()
    {
        UpdateCoinUI();
    }

    public void AddCoin()
    {
        coinsCollected++;
        coinPickupSound.Play();
        UpdateCoinUI();
    }

    private void UpdateCoinUI()
    {
        if (coinText != null)
        {
            coinText.text = "Coins: " + coinsCollected.ToString();
        }
    }
}