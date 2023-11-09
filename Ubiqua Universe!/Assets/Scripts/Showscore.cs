using UnityEngine;
using System.Collections.Generic;

public class Showscore : MonoBehaviour
{
    public float sphereRadius = 1.0f;
    public float sphereDistance = 5.0f;
    public string playerTag = "Player";
    public GameObject FloatTextPrefab;
    private GameObject currentFloatText;
    private Camera mainCamera;

    // Referência direta ao jogador para o teste de distância
    public Transform player;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        RaycastHit hit;

        // Desenha uma linha visualizando a direção e distância do SphereCast
        Debug.DrawRay(transform.position, transform.forward * sphereDistance, Color.red);

        if (Physics.SphereCast(transform.position, sphereRadius, transform.forward, out hit, sphereDistance))
        {
            if (hit.collider.CompareTag(playerTag))
            {
                ShowTotalPointsAndAverageTime();
            }
        }

        if (player != null && Vector3.Distance(transform.position, player.position) <= sphereDistance)
        {
            Debug.Log("Player is close using direct distance check!");
            ShowTotalPointsAndAverageTime();
        }

        if (currentFloatText != null)
        {
            currentFloatText.transform.LookAt(2 * currentFloatText.transform.position - mainCamera.transform.position);
        }
    }

    public void ShowTotalPointsAndAverageTime()
    {
        GeneralGameController gameController = FindObjectOfType<GeneralGameController>();
        if (gameController == null)
        {
            Debug.LogError("GeneralGameController not found!");
            return;
        }

        int totalSum = gameController.pontos;
        List<float> tempos = gameController.GetRecordedTimes();
        float averageTime = (tempos.Count > 0) ? CalculaMediaTempos(tempos) : 0f;

        string resultText = $"Total Points: {totalSum}\nAverage Time: {averageTime:0.00} seconds";
        ShowFloatText(resultText);
    }

    private float CalculaMediaTempos(List<float> tempos)
    {
        float soma = 0f;
        foreach (float tempo in tempos)
        {
            soma += tempo;
        }
        return soma / tempos.Count;
    }

    public void ShowFloatText(string text)
    {
        Debug.Log("Trying to show float text: " + text);
        HideFloatText();

        currentFloatText = Instantiate(FloatTextPrefab, transform.position + Vector3.up, Quaternion.identity);
        if (currentFloatText == null)
        {
            Debug.LogError("Failed to instantiate FloatTextPrefab!");
            return;
        }
        currentFloatText.GetComponent<TextMesh>().text = text;
    }

    public void HideFloatText()
    {
        if (currentFloatText != null)
        {
            Destroy(currentFloatText);
            currentFloatText = null;
        }
    }
}
