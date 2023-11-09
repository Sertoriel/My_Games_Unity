using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudController : MonoBehaviour
{

    public Text Score;
    public Text ScoreF;
    public Text highScore;
    public Text HighScoreF;
    public Text BonusScore;
    public Text BonusScoreF;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()// CONTROLDE DE APARIÇÃO DE SCORE NA TELA DO GAME!
    {
        if (Score && ScoreF != null)
        {
            Score.text = "SCORE:" + GameControler.score.ToString();
            ScoreF.text = "SCORE:" + GameControler.score.ToString();
        }

        if (BonusScore && BonusScoreF != null)
        {
            BonusScore.text = "BÔNUS:" + GameControler.bonusScore.ToString();
            BonusScoreF.text = "BÔNUS:" + GameControler.bonusScore.ToString();
        }
    }
}
