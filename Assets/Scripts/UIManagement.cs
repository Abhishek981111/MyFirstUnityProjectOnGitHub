using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManagement : MonoBehaviour
{
    public Button button;
    public string newScene1;

    void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        Debug.Log("Button Clicked");
        SceneManager.LoadScene(newScene1);
    }
}
