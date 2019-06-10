using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public event Action ButtonClicked;
    
    [SerializeField] private Button gameButton;

    private void Awake()
    {
        gameButton.onClick.AddListener(OnSomeButtonClicked);

        ButtonClicked += OnButtonClicked;
    }

    private void OnButtonClicked()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
		
    private void OnSomeButtonClicked() => ButtonClicked?.Invoke();

    private void OnDestroy() => ButtonClicked -= OnButtonClicked;
}
