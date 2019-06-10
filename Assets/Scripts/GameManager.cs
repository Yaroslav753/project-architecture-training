using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public event Action RandColorButtonClicked, MenuButtonClicked;
		
    [SerializeField] private Button randColorButton;
    [SerializeField] private Button menuButton;
    [SerializeField] private Image image;

    private void Awake()
    {
        //DontDestroyOnLoad(this);
			
        randColorButton.onClick.AddListener(OnRandColorClicked);
        
        menuButton.onClick.AddListener(OnMenuClicked);

        RandColorButtonClicked += OnRandColorButtonClicked;
        
        MenuButtonClicked += OnMenuButtonClicked;
    }

    private void OnRandColorButtonClicked()
    {
        image.color = new Vector4(Random.Range(0, 255)/255f, Random.Range(0, 255)/255f, Random.Range(0, 255)/255f, 1);
    }
    
    private void OnMenuButtonClicked()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    private void OnRandColorClicked()
    {
        RandColorButtonClicked?.Invoke();
    }
    
    private void OnMenuClicked()
    {
        MenuButtonClicked?.Invoke();
    }

    private void OnDestroy()
    {
        RandColorButtonClicked -= OnRandColorButtonClicked;
        MenuButtonClicked -= OnMenuButtonClicked;
    }
}
