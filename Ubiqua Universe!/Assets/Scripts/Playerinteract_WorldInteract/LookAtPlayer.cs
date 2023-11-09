using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    
    private Transform cameraTransform;

    private void Start()
    {
        // Obtém a transformação da câmera principal
        cameraTransform = Camera.main.transform;
    }

    private void Update()
    {
        // Faz o objeto olhar para a câmera
        transform.LookAt(cameraTransform);
    }
}