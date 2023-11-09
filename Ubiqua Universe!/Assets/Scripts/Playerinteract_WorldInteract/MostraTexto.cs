using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostraTexto : MonoBehaviour
{
    public GameObject FloatTextPrefab; // Prefab do texto flutuante
    private GameObject currentFloatText; // Referência para o texto flutuante atualmente exibido
    private Camera mainCamera; // Referência para a câmera principal

    private void Start()
    {
        mainCamera = Camera.main; // Obtém a referência para a câmera principal
    }

    private void Update()
    {
        // Mantém o texto flutuante sempre voltado para a câmera
        if (currentFloatText != null)
        {
            currentFloatText.transform.LookAt(2 * currentFloatText.transform.position - mainCamera.transform.position);
        }
    }

    public void ShowFloatText(string text)
    {
        // Remove o texto flutuante anterior, se houver
        HideFloatText();

        // Instancia o novo texto flutuante acima do objeto atual
        currentFloatText = Instantiate(FloatTextPrefab, transform.position + Vector3.up, Quaternion.identity);

        // Define o texto a ser exibido no objeto do texto flutuante
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
