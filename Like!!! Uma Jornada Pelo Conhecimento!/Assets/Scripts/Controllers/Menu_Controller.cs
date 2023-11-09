using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// CONTROLE DE START GAME /MENU
public class Menu_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Resetable Static Stuff.
        //Quiz
        Quiz_Controllers.QuizSequance = 0;
        Quiz_Controllers.GoQuiz = false;
        //GameControler
        //GameControler.LoadData();
        GameControler.Multplier = 0;
        GameControler.bonusScore = 0;
        GameControler.FinalScore = 0;
        GameControler.score = 0;
        GameControler.speed = 10f;
        GameControler.TimeToSpawn = 5f;
        GameControler.gameOver = false;
        //ApresentaNext
        ApresentaNext.FakeloadCount = 0;
        //PlayerController
        PlayerController.WonlevelC = 0;
    }
    public void StartGame()
    {
        SceneManager.LoadScene("ApresentaçãoUbq");
    }

    public void Goback()
    {
        SceneManager.LoadScene("Menu");
    }


    public void GoCredit()
    {
        SceneManager.LoadScene("Credits");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
