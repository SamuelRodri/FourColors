using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    
    public AudioSource[] sounds;
    public AudioSource recreo;
    public AudioSource campana;
    
    // Start is called before the first frame update
    void Start()
    {
        sounds = GetComponents<AudioSource>();
        recreo = sounds[0];
        campana = sounds[1];

        recreo.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartCamapana()
    {
        campana.Play();
    }
        
}
