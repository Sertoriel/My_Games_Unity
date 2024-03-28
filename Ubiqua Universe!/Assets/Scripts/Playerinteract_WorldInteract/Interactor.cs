using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Interactor : MonoBehaviour
{
    public MostraTexto Texto;
    public string textoAmostrar;
    private bool isShown;

    public float sphereRadius = 1.0f;  // O raio da esfera do SphereCast
    public float sphereDistance = 5.0f;  // Distância que o SphereCast irá verificar

    public string nomeCena;  // Nome da cena para qual você deseja trocar

    public Canvas interactCanvas;
    public Button interactButton;
    public Text interactButtonText;
    public bool Canvas;
    public bool Btm;

    private void Start()
    {
        // Desativa o canvas e o botão no início
        interactCanvas.gameObject.SetActive(Canvas = false);
        interactButton.gameObject.SetActive(Btm = false);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;

        isShown = false;
    }

    void Update()
    {
        if (Canvas == true)
        {
            // Atualiza a detecção constantemente enquanto o canvas estiver ativo
            CheckForColliders();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            GoMiniGame();
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position + transform.forward * sphereDistance, sphereRadius);
        Gizmos.DrawLine(transform.position, transform.position + transform.forward * sphereDistance);
    }

    void CheckForColliders()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position + transform.forward * sphereDistance, sphereRadius, LayerMask.GetMask("Interactable"));

        if (hitColliders.Length > 0)
        {
            foreach (var hitCollider in hitColliders)
            {
                Debug.Log(hitCollider.name + " was hit!");
            }

            // Ativa o texto interativo quando for detectado
            if (!isShown) Texto.ShowFloatText(textoAmostrar);
            isShown = true;

            // Ativa o botão quando um colisor Interactable for detectado
            interactButton.gameObject.SetActive(Btm = true);
            interactButtonText.text = "Acessar MiniGame UBÍQUA!";
        }
        else
        {
            // Desativa o Texto.
            if (isShown) Texto.HideFloatText();
            isShown = false;

            // Desativa o botão se nenhum colisor Interactable for detectado
            interactButton.gameObject.SetActive(Btm = false);
        }
    }

    public void GoMiniGame()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position + transform.forward * sphereDistance, sphereRadius, LayerMask.GetMask("Interactable"));

        if (hitColliders.Length > 0)
        {
            Debug.Log(hitColliders[0].name + " can go to the game!"); // Esta linha assume que você está interessado no primeiro objeto detectado. Ajuste conforme necessário.
            TrocarParaNovaCena();
        }
    }

    public void TrocarParaNovaCena()
    {
        SceneManager.LoadScene(nomeCena);
    }
}
