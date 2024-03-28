using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControllerNegocios : MonoBehaviour, IGameController
{
    public int pontos = 0;
    public int numquest = 0;
    private int DubletapC = 0;

    public Text score1;
    public Text score2;

    public TimerController timer;
    public ImageChange image;
    public VariableHandlerNeg variableHandler;
    public CaixaTexto cabecalho;
    public BotaoTextoNegocios botao;
    public int index = 0;

    [SerializeField] private string sceneToLoad;  // O nome da cena que você quer carregar
                                                  // Nome da cena para onde o jogador será mandado
    [SerializeField] private string cenaParaEnviar;

    private void Start()
    {

        numquest = 0;

        // Permite que o cursor se mova livremente pela tela
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void Update()
    {

        score1.text = "Score: " + pontos;
        score2.text = "Score: " + pontos;

        Dubletap();

        if (Input.GetKeyDown(KeyCode.Q))
        {
            GeneralGameController gameController = FindObjectOfType<GeneralGameController>();
            gameController.AcumularPontos();
            LoadSpecifiedScene();
        }
    }

    // Método que é chamado quando o jogador toca na tela
    public void Dubletap()
    {
        if (Input.touchCount > 0 && numquest >= 6)
        {
            Debug.Log("Tocou");
            Touch t = Input.GetTouch(0);

            DubletapC++;

            if (!string.IsNullOrEmpty(cenaParaEnviar) && DubletapC == 2)
            {

                GeneralGameController gameController = FindObjectOfType<GeneralGameController>();
                gameController.AcumularPontos();
                LoadSpecifiedScene();

                // Manda o jogador para a cena
                // SceneManager.LoadScene(cenaParaEnviar);
            }
        }
    }

    public void CheckRespostas(int buttonIndex)
    {
        if (botao.buttonTexts[buttonIndex].text == variableHandler.Questões[index].RespQ)
        {

            numquest += 1;
            pontos += 10;
            botao.MudarFonteResposta();
            cabecalho.AtualizarTexto();
            image.TrocarImagem();
            timer.RegistrarTempo();
            Debug.Log(pontos);
            index++;

        }
        else
        {
            if (pontos != 0)
            {
                pontos -= 1;
            }
        }
    }

    void LoadSpecifiedScene()
    {
        if (!string.IsNullOrEmpty(sceneToLoad))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.LogError("Nome da cena não definido. Por favor, defina-o no Editor da Unity.");
        }
    }

    public int GetPoints()
    {
        return pontos;
    }

}

