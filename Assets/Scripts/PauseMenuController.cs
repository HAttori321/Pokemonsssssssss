using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuController : MonoBehaviour
{
    public RectTransform arrow;
    public RectTransform text1;
    public RectTransform text2;

    public int counter = 0;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            arrow.anchoredPosition = new Vector2(arrow.anchoredPosition.x, text1.anchoredPosition.y);
        if (Input.GetKeyDown(KeyCode.DownArrow))
            arrow.anchoredPosition = new Vector2(arrow.anchoredPosition.x, text2.anchoredPosition.y);

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (counter == 0)
            {
                this.gameObject.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }
}
