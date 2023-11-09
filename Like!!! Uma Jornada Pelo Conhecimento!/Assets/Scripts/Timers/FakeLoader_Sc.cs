using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Security.Cryptography;
using UnityEngine.SceneManagement;

public class FakeLoader_Sc : MonoBehaviour
{

    private float limit = 20;
    public Text Score;
    public Text ScoreF;

    private void Start() 
    {
        InvokeRepeating("FakeLoad", 1f, 1f);    

        Score.text = "Score: " + GameControler.score.ToString();
        ScoreF.text = "Score: " + GameControler.score.ToString();

        Debug.Log(ApresentaNext.FakeloadCount);

    }

    void FakeLoad()
    {
        if(!GameControler.gameOver)
        {
            transform.Translate(Vector3.forward * 5);
        }   

        if(transform.position.x > limit && gameObject.CompareTag("Player") && ApresentaNext.FakeloadCount == 1)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Main_1Cria");
        }else if(transform.position.x > limit && gameObject.CompareTag("Player") && ApresentaNext.FakeloadCount == 3)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Main_1Sponsor");
        }else if(transform.position.x > limit && gameObject.CompareTag("Player") && ApresentaNext.FakeloadCount == 5)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Main_2Experience");
        }else if(transform.position.x > limit && gameObject.CompareTag("Player") && ApresentaNext.FakeloadCount == 7)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Main_2Campeão");
        }else if(transform.position.x > limit && gameObject.CompareTag("Player") && ApresentaNext.FakeloadCount == 9)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Main_3Osga");
        }else if(transform.position.x > limit && gameObject.CompareTag("Player") && ApresentaNext.FakeloadCount == 11)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Main_4Negocios");
        }




        if(transform.position.x > limit && ApresentaNext.FakeloadCount == 2 && gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("WinScreenCria");
        }
        else if(transform.position.x > limit && ApresentaNext.FakeloadCount == 4 && gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("WinScreenSponsor");
        }else if(transform.position.x > limit && ApresentaNext.FakeloadCount == 6 && gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("WinScreenExperience");
        }else if(transform.position.x > limit && ApresentaNext.FakeloadCount == 8 && gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("WinScreenCampeão");
        }else if(transform.position.x > limit && ApresentaNext.FakeloadCount == 10 && gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("WinScreenOsga");
        }else if(transform.position.x > limit && ApresentaNext.FakeloadCount == 12 && gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("WinScreenNegócios");
        }else if(transform.position.x > limit && ApresentaNext.FakeloadCount == 13 && gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameWim");
        }
        
        
    }
}
