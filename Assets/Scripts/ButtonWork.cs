using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonWork : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void EnterGame()
    {
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
