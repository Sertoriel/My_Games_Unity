using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ApresentaNext : MonoBehaviour
{

    [Header("TimersComp")]
    public float Tempo_de_Video = 60;
    public float Tempo_Decorrido;
    public static float FakeloadCount = 0;

    [Header("ButtomConfigComp")]
    public float tempoParaPular = 5;
    private IEnumerator couroutine;
    public GameObject BTM;

    void Start()
    {
        couroutine = ShowB();
        StartCoroutine(couroutine);
        Debug.Log(Quiz_Controllers.GoQuiz + "Quiz");
    }

    private IEnumerator ShowB()
    {
        while (true)
        {
            yield return new WaitForSeconds(tempoParaPular);
            if(!GameControler.gameOver) BTM.SetActive(true);
        }
    }

    void Update() // Nesse update O codigo irá verificar se deve ir para o quiz ou o fakeload.
    {
        if(Tempo_Decorrido < Tempo_de_Video)
        {
            Tempo_Decorrido = Tempo_Decorrido + Time.deltaTime;
            if(Tempo_Decorrido > Tempo_de_Video && Quiz_Controllers.GoQuiz == true)
            switch (Quiz_Controllers.QuizSequance)
            {
                case 1:
                SceneManager.LoadScene("QuizCria");
                break;
                case 2:
                SceneManager.LoadScene("QuizSponsor");
                break;
                case 3:
                SceneManager.LoadScene("QuizExperience");
                break;
                case 4:
                SceneManager.LoadScene("QuizCampeão");
                break;
                case 5:
                SceneManager.LoadScene("QuizOsga");
                break;
                case 6:
                SceneManager.LoadScene("QuizNegocios");
                break;
            }else if(Tempo_Decorrido > Tempo_de_Video && Quiz_Controllers.GoQuiz == false)
            {
                Tempo_Decorrido = Tempo_Decorrido + Time.deltaTime;
                if(Tempo_de_Video < Tempo_Decorrido)SceneManager.LoadScene("FakeLoad");
                if(Tempo_de_Video < Tempo_Decorrido)FakeloadCount += 1;
            }
        }

    }

    public void Pular()
    {
        if(Tempo_Decorrido > tempoParaPular && Quiz_Controllers.GoQuiz == false);
        {
            SceneManager.LoadScene("FakeLoad");
            FakeloadCount += 1;
        }
    }

    public void PularPQuiz()
    {
        if(Tempo_Decorrido > tempoParaPular && Quiz_Controllers.GoQuiz == true)
        switch (Quiz_Controllers.QuizSequance)
        {
            case 1:
            SceneManager.LoadScene("QuizCria");
            break;
            case 2:
            SceneManager.LoadScene("QuizSponsor");
            break;
            case 3:
            SceneManager.LoadScene("QuizExperience");
            break;
            case 4:
            SceneManager.LoadScene("QuizCampeão");
            break;
            case 5:
            SceneManager.LoadScene("QuizOsga");
            break;
            case 6:
            SceneManager.LoadScene("QuizNegocios");
            break;
        }
    }
}