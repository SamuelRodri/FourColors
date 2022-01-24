using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    GameController gameController;
    public List<Piece> adjacentPieces = new List<Piece>();
    public Colors mycolor;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();    
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameController.ColorPiece(this);
        }
    }

    // Detect the adjacents pieces
    private void OnCollisionStay2D(Collision2D collision)
    {
        Piece piece = collision.gameObject.GetComponent<Piece>();

        if (!adjacentPieces.Contains(piece))
        {
            adjacentPieces.Add(collision.gameObject.GetComponent<Piece>());
        }
    }
}
