using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour
{

    public static float speed = 10f;//controle de Game Vell
    public static float TimeToSpawn = 5f;//Controle tempo de Spawn
    public static float score = 0f;//game points.
    public static float bonusScore = 0f;//bonus score.
    public static float Hscore = 0f;//pontos multiplicados.
    public static float FinalScore = 0f;//Score Final.
    public static bool gameOver = false;//controla o estado de game
    public static float grow = 0;// taxa de crescimento do Selo
    public static float Multplier = 0;//Multiplicador de ponto bonus.

    public void LoadData()
    {
        GameControler.Hscore = PlayerPrefs.GetFloat("HighScore",0f);
    }


    public void SaveData()
    {
        if (GameControler.score > GameControler.Hscore)
        {
            PlayerPrefs.SetFloat("HighScore", GameControler.Hscore);
            PlayerPrefs.Save();
        }
        
    }





    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        // //Carrega os dados.
        GameControler.Multplier = 0f;
        GameControler.speed = 10f;
        GameControler.TimeToSpawn = 5f;
        GameControler.grow = 0f;
        GameControler.gameOver = false;

        InvokeRepeating("DificultLevel",1f, 5f);

    }
    //controle de dificuldade.
    private void DificultLevel()
    {
        if (!GameControler.gameOver)
        {
            GameControler.speed +=1;
            GameControler.TimeToSpawn = Mathf.Clamp(GameControler.TimeToSpawn-1f, 3f ,10f);
        }
    }
}
