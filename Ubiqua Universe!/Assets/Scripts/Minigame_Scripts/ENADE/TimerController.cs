using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public Text timerText1;
    public Text timerText2;

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        string minutes = ((int)timer / 60).ToString("00");
        string seconds = (timer % 60).ToString("00");

        timerText1.text = minutes + ":" + seconds;
        timerText2.text = minutes + ":" + seconds;
    }

    public void RegistrarTempo()
    {
        GeneralGameController gameController = FindObjectOfType<GeneralGameController>();
        if (gameController != null)
        {
            gameController.AddRecordedTime(timer);
        }
    }
}
