using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpherecastNextScene : MonoBehaviour
{
    public float sphereRadius = 1.0f;  // O raio da esfera do SphereCast
    public float sphereDistance = 5.0f;  // Distância que o SphereCast irá verificar
    public string playerTag = "Player";  // A tag do jogador

    public string sceneToLoad;  // Nome da cena para carregar

    void Update()
    {
        RaycastHit hit;

        // Faça o SphereCast a partir da posição deste objeto para frente
        if (Physics.SphereCast(transform.position, sphereRadius, transform.forward, out hit, sphereDistance))
        {
            if (hit.collider.CompareTag(playerTag))  // Verifica se o objeto atingido tem a tag correta
            {
                LoadSceneByName();
            }
        }
    }

    void LoadSceneByName()
    {
        if (!string.IsNullOrEmpty(sceneToLoad))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.LogWarning("Nome da cena não definido!");
        }
    }
}
