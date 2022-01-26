using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PolygonGenerator : MonoBehaviour
{
    public GameObject[] pieces;
    public static float yLimit = 7.77f;
    public static float xRange = 6.5f;
    Random random = new Random();
    public float frecuency;
    private int delay = 150;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0, 9) > frecuency && delay == 0)
        {
            int x = ((int)Random.Range(-xRange, xRange + 1));
            GameObject piece = pieces[((uint)Random.Range(0, 9))];
            Instantiate(piece, new Vector3(x, yLimit, 0), piece.transform.rotation);
            delay = 150;
        }
        else if (delay > 0)
        {
            delay--;
        }
    }
}
