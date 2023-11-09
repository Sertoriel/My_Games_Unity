using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaixaTexto : MonoBehaviour
{
    public Text textoCaixa;
    public float velocidadeDigitacao = 0.1f;
    public float atrasoInicial = 1f;

    public string[] textos;
    private int currentIndex = 0;
    private Coroutine exibicaoCoroutine;

    public void Start()
    {
        StartCoroutine(ExibirTextoPorLetras());
    }

    public void AtualizarTexto()
    {
        currentIndex++;
        if (currentIndex >= textos.Length)
        {
            currentIndex = 0; // Reinicia o índice para mostrar o primeiro texto novamente
        }

        if (exibicaoCoroutine != null)
        {
            StopCoroutine(exibicaoCoroutine);
        }
        exibicaoCoroutine = StartCoroutine(ExibirTextoPorLetras());
    }

    private IEnumerator ExibirTextoPorLetras()
    {
        yield return new WaitForSeconds(atrasoInicial);

        string textoCompleto = textos[currentIndex];
        for (int i = 0; i <= textoCompleto.Length; i++)
        {
            string textoExibido = textoCompleto.Substring(0, i);
            textoCaixa.text = textoExibido;

            yield return new WaitForSeconds(velocidadeDigitacao);
        }
    }
}
