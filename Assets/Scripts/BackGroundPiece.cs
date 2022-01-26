﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundPiece : MonoBehaviour
{
    [SerializeField]float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        if (transform.position.y <= -PolygonGenerator.yLimit)
        {
            Destroy(this.gameObject);
        }
    }
}
