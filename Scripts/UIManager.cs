using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text TimeText;
    public GameObject StartButton;
    public GameObject ClearText;
    public GameObject RestartButton;

    public void SetTimeText(float time)
    {
        TimeText.text = "Time:" + time.ToString("f1");
    }

    public void DeleteInitialUI()
    {
        StartButton.SetActive(false);
    }

    public void EnableClearUI()
    {
        ClearText.SetActive(true);
        RestartButton.SetActive(true);
        TimeText.color = Color.yellow;
    }
}
