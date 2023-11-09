using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{
    void Update()
    {
        if(!GameControler.gameOver)
        {
            transform.localScale = new Vector3 (1, 1, 1) * GameControler.grow / 100;
        }        
        Debug.Log(GameControler.grow);
    }
}
