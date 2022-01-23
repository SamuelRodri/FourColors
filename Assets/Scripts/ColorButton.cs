using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorButton : MonoBehaviour
{
    GameController gameController;

    public Colors mycolor;
    new AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        audio = GetComponent<AudioSource>();
    }

    public void PlayAudio()
    {
        audio.Play();
    }
}
