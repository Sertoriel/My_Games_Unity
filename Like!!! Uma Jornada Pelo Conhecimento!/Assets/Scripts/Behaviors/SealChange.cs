using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SealChange : MonoBehaviour
{

    [Header("Comps")]
    public GameObject Info;
    public GameObject LikesEGhost;
    public GameObject Seal1;
    public GameObject Seal2;
    public GameObject Seal3;
    public GameObject Seal4;
    public GameObject Seal5;
    public GameObject Seal6;

    // Start is called before the first frame update
    void Start()
    {
        if(Quiz_Controllers.GoQuiz == true)
        {
            Info.SetActive(false);
            LikesEGhost.SetActive(false);
        }else
        {
            Info.SetActive(true);
            LikesEGhost.SetActive(true);
        }

        if(Quiz_Controllers.GoQuiz == true)
        {
            switch (Quiz_Controllers.QuizSequance)
            {
                case 1:
                Seal1.SetActive(true);
                break;
                case 2:
                Seal2.SetActive(true);
                break;
                case 3:
                Seal3.SetActive(true);
                break;
                case 4:
                Seal4.SetActive(true);
                break;
                case 5:
                Seal5.SetActive(true);
                break;
                case 6:
                Seal6.SetActive(true);
                break;
            }
        }
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/
}
