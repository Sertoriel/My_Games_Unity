using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotaoTextoSpon : MonoBehaviour
{
    public Button[] buttons;
    public Text[] buttonTexts;
    public VariableHandlerSpon variableHandler;  // Referência para o script VariableHandler
    public GameControllerSpon gameController;

    private int[] indices;
    private dadosRespostasasSpon[] respostaAtual;  // Array para armazenar a resposta atual
    private int indiceRespostaAtual = 0;  // Indice para controlar qual conjunto de respostas está sendo usado

    private void Start()
    {
        indices = new int[buttons.Length];
        
        respostaAtual = variableHandler.RespostasList[indiceRespostaAtual]; // Use o índice para pegar o conjunto de respostas inicial

        for (int i = 0; i < indices.Length; i++)
        {
            // Remover o código `Random.Range(0, respostaAtual.Length)`
            indices[i] = i;
            AtualizarTextoBotao(i);
        }
    }

    public void OnClick(int buttonIndex)
    {
        // Mostra o texto atual no console
        Debug.Log(buttonTexts[buttonIndex].text);

        gameController.CheckRespostas(buttonIndex);

        // Atualiza o índice do texto para esse botão
        // Atualiza o código para usar o índice do botão como índice do texto
        indices[buttonIndex] = buttonIndex;

        // Atualiza o texto do botão
        AtualizarTextoBotao(buttonIndex);
    }

    public void MudarFonteResposta()
    {
        indiceRespostaAtual++;

        // Se o índice for maior ou igual ao número de conjuntos de respostas, ele voltará ao início
        if (indiceRespostaAtual >= variableHandler.RespostasList.Count)
        {
            indiceRespostaAtual = 0;
        }

        respostaAtual = variableHandler.RespostasList[indiceRespostaAtual];

        for (int i = 0; i < indices.Length; i++)
        {
            // Atualiza o índice do texto para esse botão
            // Atualiza o código para usar o índice do botão como índice do texto
            indices[i] = i;
            AtualizarTextoBotao(i);
        }
    }

    public void AtualizarTextoBotao(int buttonIndex)
{
    // Atualiza o código para usar o índice do botão como índice do texto, mas com o índice invertido
    buttonTexts[buttonIndex].text = respostaAtual[respostaAtual.Length - buttonIndex - 1].Resp;
}
}