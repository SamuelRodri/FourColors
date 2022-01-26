using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public static class StringExtensions
{
    public static string AddColor(this string text, Color col) => $"<color={ColorHexFromUnityColor(col)}>{text}</color>";
    public static string ColorHexFromUnityColor(this Color unityColor) => $"#{ColorUtility.ToHtmlStringRGBA(unityColor)}";
}

public class MainController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI title;

    private Color[] colors = { new Color32(209,37,37,255), new Color32(46,166,23,255), new Color32(23,52,166,255), new Color32(224,215,35,255) };
    private void Awake()
    {
        initializeTitle();
    }

    // Set colors to the game title
    void initializeTitle()
    {
        title.SetText($"" +
            $"{"F".AddColor(colors[0])}" +
            $"{"o".AddColor(colors[1])}" +
            $"{"u".AddColor(colors[2])}" +
            $"{"r".AddColor(colors[3])}" +
            $"{" ".AddColor(colors[0])}" +
            $"{"C".AddColor(colors[1])}" +
            $"{"o".AddColor(colors[2])}" +
            $"{"l".AddColor(colors[3])}" +
            $"{"o".AddColor(colors[0])}" +
            $"{"r".AddColor(colors[1])}" +
            $"{"s".AddColor(colors[2])}" +
            $"{"".AddColor(colors[3])}");
        
    }

    private IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Menu");
    }

    public void LoadMenu()
    {
        StartCoroutine(WaitForSceneLoad());
    }

    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
