using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver_Controller : MonoBehaviour
{

    public Text FinalScore;
    public Text FinalScoreF;

    private Touch tap;


    // Start is called before the first frame update
    void Start()
    {
        //Save Game Data

            

        //Update Screem Itens
        if(FinalScore && FinalScoreF != null)
        {
            GameControler.FinalScore = GameControler.score + GameControler.bonusScore;
            FinalScore.text = "Score Final: " + GameControler.FinalScore.ToString() + "!!";
            FinalScoreF.text = "Score Final: " + GameControler.FinalScore.ToString() + "!!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        //go to menu
        if(Input.touchCount > 0)
        {
            tap = Input.GetTouch(0);
            if (tap.phase == TouchPhase.Began)
            {
                Invoke("GoMenu", 2f);
            }
        }

    }

    void GoMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}