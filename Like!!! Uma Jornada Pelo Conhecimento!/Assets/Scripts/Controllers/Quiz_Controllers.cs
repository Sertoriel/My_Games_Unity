using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class Quiz_Controllers : MonoBehaviour
{
    [Header("comp")]
    public Text perguntas;
    public Text perguntasF;
    public Button Yes;
    public Button No;
    public static int QuizSequance;
    public static bool GoQuiz;
    private AudioSource ButtonAudio;

    [Header("changeableStuff")]
    private string[] FrasesPergunts;
    private int index;
    public float typingSpeed;
    public string[] txt;
    public AudioClip Acerto;
    public AudioClip Erro;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(QuizSequance);
        ButtonAudio = GetComponent<AudioSource>();
        Debug.Log("FakeLoaderC" + ApresentaNext.FakeloadCount);
        if(perguntas && perguntasF !=null)
        {
            FrasesPergunts = txt;
            StartCoroutine(TypeSentence());
        }

        GoQuiz = false;
    }

    // Update is called once per frame
    public async void AnswerCheckerYes()
    {
        if(QuizSequance == 1)//Cria Falso.
        {
            ButtonAudio.PlayOneShot(Erro);
            await Task.Delay(1000);
            SceneManager.LoadScene("Fakeload");
            ApresentaNext.FakeloadCount += 1;

        }else if(QuizSequance == 2)//Sponsor Verdadeiro.
        {
            ButtonAudio.PlayOneShot(Acerto);
            await Task.Delay(2000);
            GameControler.Multplier += 2;
            ApplyMultiply();
            SceneManager.LoadScene("Fakeload");
            ApresentaNext.FakeloadCount += 1;

        }else if(QuizSequance == 3)//Experience Falso.
        {
            ButtonAudio.PlayOneShot(Erro);
            await Task.Delay(1000);
            SceneManager.LoadScene("Fakeload");
            ApresentaNext.FakeloadCount += 1;

        }else if(QuizSequance == 4)//Campeão Verdadeiro.
        {
            ButtonAudio.PlayOneShot(Acerto);
            await Task.Delay(2000);
            GameControler.Multplier += 2;
            ApplyMultiply();
            SceneManager.LoadScene("Fakeload");
            ApresentaNext.FakeloadCount += 1;

        }else if(QuizSequance == 5)//Osga Verdadeiro.
        {
            ButtonAudio.PlayOneShot(Acerto);
            await Task.Delay(2000);
            GameControler.Multplier += 2;
            ApplyMultiply();
            SceneManager.LoadScene("Fakeload");
            ApresentaNext.FakeloadCount += 1;

        }else if(QuizSequance == 6)//Negocios Verdadeiro.
        {
            ButtonAudio.PlayOneShot(Acerto);
            await Task.Delay(2000);
            GameControler.Multplier += 2;
            ApplyMultiply();
            SceneManager.LoadScene("Fakeload");
            ApresentaNext.FakeloadCount += 1;

        }
    }
    public async void AnswerCheckerNO()
    {
        if(QuizSequance == 1)//Cria Verdadeiro.
        {
            ButtonAudio.PlayOneShot(Acerto);
            await Task.Delay(2000);
            GameControler.Multplier += 2;
            ApplyMultiply();
            SceneManager.LoadScene("Fakeload");
            ApresentaNext.FakeloadCount += 1;

        }else if(QuizSequance == 2)//Sponsor Falso.
        {
            ButtonAudio.PlayOneShot(Erro);
            await Task.Delay(1000);
            SceneManager.LoadScene("Fakeload");
            ApresentaNext.FakeloadCount += 1;

        }else if(QuizSequance == 3)//Experience Verdadeiro.
        {
            ButtonAudio.PlayOneShot(Acerto);
            await Task.Delay(2000);
            GameControler.Multplier += 2;
            ApplyMultiply();
            SceneManager.LoadScene("Fakeload");
            ApresentaNext.FakeloadCount += 1;

        }else if(QuizSequance == 4)//Campeão Falso.
        {
            ButtonAudio.PlayOneShot(Erro);
            await Task.Delay(1000);
            SceneManager.LoadScene("Fakeload");
            ApresentaNext.FakeloadCount += 1;

        }else if(QuizSequance == 5)//Osga Falso.
        {
            ButtonAudio.PlayOneShot(Erro);
            await Task.Delay(1000);
            SceneManager.LoadScene("Fakeload");
            ApresentaNext.FakeloadCount += 1;

        }else if(QuizSequance == 6)//Negocios Falso.
        {
            ButtonAudio.PlayOneShot(Erro);
            await Task.Delay(1000);
            SceneManager.LoadScene("Fakeload");
            ApresentaNext.FakeloadCount += 1;

        }
    }

    IEnumerator TypeSentence()
    {
        foreach (char letras in FrasesPergunts[index].ToCharArray())
        {
            perguntas.text += letras;
            perguntasF.text += letras;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    private void ApplyMultiply()
    {
        GameControler.bonusScore = GameControler.score * GameControler.Multplier;
    }

}
