using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonLevel : MonoBehaviour
{
    string level;
    Text text;
    private bool completed;

    private void Start()
    {
        level = gameObject.name;
        text = gameObject.transform.GetChild(0).GetComponent<Text>();
        text.text = level;
        text.fontSize = 20;
        text.fontStyle = FontStyle.Bold;
        text.color = new Color(1, 1, 1);
        completed = false;
    }

    public void GoToLevel()
    {
        SceneManager.LoadScene(level);
    }
}
