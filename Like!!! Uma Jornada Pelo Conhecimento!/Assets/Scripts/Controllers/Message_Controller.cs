using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Message_Controller : MonoBehaviour
{
    [Header("Components")]
    public GameObject dialogueObj;
    public Text frases;

    [Header("Settings")]
    public float typingSpeed;   
    private string[] sentences;
    private int index;



    public void Speak(string[] txt)
    {
        if(GameControler.score == 10 || GameControler.score == 90 || GameControler.score == 150 || GameControler.score == 220 || GameControler.score == 280 || GameControler.score == 350 || GameControler.score == 420)
        {
            dialogueObj.SetActive(true);
            sentences = txt;
            StartCoroutine(TypeSentence());
        }
        else if(frases.text == sentences[index])
        {
            //ainda tem Frases
            if(index < sentences.Length - 1)
            {
                index++;
                frases.text = "";
                StartCoroutine(TypeSentence());
            }else// quanto terminar as frases
            {
                frases.text = "";
                index = 0;
                dialogueObj.SetActive(false);
            }
        }
    }

    IEnumerator TypeSentence()
    {
        foreach (char letras in sentences[index].ToCharArray())
        {
            frases.text += letras;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    /*public void ProximaFrase()
    {
        if(frases.text == sentences[index])
        {
            //ainda tem Frases
            if(index < sentences.Length - 1)
            {
                index++;
                frases.text = "";
                StartCoroutine(TypeSentence());
            }else// quanto terminar as frases
            {
                frases.text = "";
                index = 0;
                dialogueObj.SetActive(false);
            }
        }
    }*/
    
    


    /*string text1 = "Dale Só Testando Mesmo!!";
    char[] ctr;
    public Text viewer;
    public Text viewerf;

    // Start is called before the first frame update
    void Start()
    {
        ctr = text1.ToCharArray();
        ShowText();       
    }

    IEnumerator ShowText()
    {
        
        int count = 0;
        do
        {
            yield return new WaitForSeconds(0.3f);
            viewer.text += ctr[count];
            viewerf.text += ctr[count];
            count ++;
        }
        while(count < ctr.Length);

    }*/

}
