using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChange : MonoBehaviour
{
    public Sprite[] sprites; // Array de sprites

    private Image image;
    private int currentSpriteIndex = 0;

    void Start()
    {
        image = GetComponent<Image>();

        // Verifica se há sprites atribuídos
        if (sprites.Length > 0)
        {
            image.sprite = sprites[currentSpriteIndex];
        }
    }

    public void TrocarImagem()
    {
        currentSpriteIndex++;

        // Verifica se o índice é maior que o tamanho da matriz de sprites
        if (currentSpriteIndex >= sprites.Length)
        {
            currentSpriteIndex = 0; // Reinicia o índice para mostrar o primeiro sprite novamente
        }

        // Altera o sprite renderizado
        image.sprite = sprites[currentSpriteIndex];
    }
}
