using UnityEngine;
using UnityEngine.SceneManagement;

public class SpherecastPreviousScen : MonoBehaviour
{
    private const string lastSceneKey = "LastScene";

    public float sphereRadius = 1.0f;
    public float sphereDistance = 5.0f;
    public string playerTag = "Player";

    void Update()
    {
        RaycastHit hit;
        if (Physics.SphereCast(transform.position, sphereRadius, transform.forward, out hit, sphereDistance))
        {
            if (hit.collider.CompareTag(playerTag))
            {
                LoadPreviousScene();
            }
        }
    }

    void LoadPreviousScene()
    {
        GeneralGameController gameController = FindObjectOfType<GeneralGameController>();
        string lastSceneName = gameController.GetLastSceneName();

        if (!string.IsNullOrEmpty(lastSceneName) && lastSceneName != SceneManager.GetActiveScene().name)
        {
            SceneManager.LoadScene(lastSceneName);
        }
        else
        {
            Debug.LogWarning("Nome da cena anterior não encontrado ou a cena atual é a cena anterior!");
        }
    }
}
