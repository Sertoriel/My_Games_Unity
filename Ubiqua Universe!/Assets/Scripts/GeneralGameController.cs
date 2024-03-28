using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class GeneralGameController : MonoBehaviour
{
    public int pontos = 0;
    private const string lastSceneKey = "LastScene";
    private const string totalPointsKey = "TotalPoints";
    private const string temposKey = "TemposRegistrados";
    public List<float> temposRegistradosGlobal = new List<float>();

    private void Start()
    {

        CarregarPontos();
        CarregarTempos();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            ResetarPontos();
        }
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        RememberCurrentScene();
    }

    public void AcumularPontos()
    {
        pontos += GetPointsFromController<GameControllerCampeao>();
        pontos += GetPointsFromController<GameControllerCria>();
        pontos += GetPointsFromController<GameControllerExperience>();
        pontos += GetPointsFromController<GameControllerNegocios>();
        pontos += GetPointsFromController<GameControllerOsg>();
        pontos += GetPointsFromController<GameControllerSpon>();

        SalvarPontos();
    }

    private int GetPointsFromController<T>() where T : MonoBehaviour
    {
        T controller = FindObjectOfType<T>();
        if (controller != null && controller is IGameController)
        {
            return (controller as IGameController).GetPoints();
        }
        return 0;
    }

    void RememberCurrentScene()
    {
        if (SceneManager.GetActiveScene().name != "MainScene")
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            PlayerPrefs.SetString(lastSceneKey, currentSceneName);
            PlayerPrefs.Save();
        }
    }

    public string GetLastSceneName()
    {
        return PlayerPrefs.GetString(lastSceneKey, "");
    }

    public void AddRecordedTime(float tempo)
    {
        temposRegistradosGlobal.Add(tempo);
        SalvarTempos();
    }

    public List<float> GetRecordedTimes()
    {
        return temposRegistradosGlobal;
    }

    private void SalvarPontos()
    {
        PlayerPrefs.SetInt(totalPointsKey, pontos);
        PlayerPrefs.Save();
    }

    private void SalvarTempos()
    {
        TemposContainer container = new TemposContainer { tempos = temposRegistradosGlobal };
        string temposString = JsonUtility.ToJson(container);
        PlayerPrefs.SetString(temposKey, temposString);
        PlayerPrefs.Save();
    }

    private void CarregarPontos()
    {
        pontos = PlayerPrefs.GetInt(totalPointsKey, 0);
    }

    private void CarregarTempos()
    {
        string temposString = PlayerPrefs.GetString(temposKey, "");
        if (!string.IsNullOrEmpty(temposString))
        {
            TemposContainer container = JsonUtility.FromJson<TemposContainer>(temposString);
            temposRegistradosGlobal = container.tempos;
        }
    }

    public void ResetarPontos()
    {
        pontos = 0;
        temposRegistradosGlobal.Clear();
        SalvarPontos();
        SalvarTempos();
    }
}
