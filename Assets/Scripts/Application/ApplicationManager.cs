using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Application
{
    public class ApplicationManager : MonoBehaviour
    {
       [SerializeField] private MenuManager MenuManager;
       [SerializeField] private GameManager GameManager;

        private void Awake()
        {
            //DontDestroyOnLoad(this);
			
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
    }
}