using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Button redButton;
    public Button grayButton;

    //private static int red = 0;
    //private static int gray = 1;
    public static int clickedButton;

    void Start()
    {
        Button btnred = redButton.GetComponent<Button>();
        Button btngray = grayButton.GetComponent<Button>();
        btnred.onClick.AddListener(redClick);
        btngray.onClick.AddListener(grayClick);
    }

    void redClick()
    {
        clickedButton = 0;
        SceneManager.LoadScene("Game");
    }

    void grayClick()
    {
        clickedButton = 1;
        SceneManager.LoadScene("Game");
    }
}
