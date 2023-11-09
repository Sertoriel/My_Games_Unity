using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMessage : MonoBehaviour
{

    public string[] frases;

    private Message_Controller mc;

    private void Start()
    {

        mc = FindObjectOfType<Message_Controller>();

    }

    private void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject.CompareTag("Points"))
        {
            mc.Speak(frases);
        }
    }
































    /*public GameObject[] MessageSingu;
    private Vector3 ShowPos = new Vector3 (6, 3, -2);

    void ShowMessag()
    {
        switch (GameControler.score)
        {
            case 10:
            GameObject messagesingu = MessageSingu[0];
            Instantiate (messagesingu, ShowPos, messagesingu.transform.rotation);
            break;
        }
    }*/
}
