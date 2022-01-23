using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private Colors actualColor;

    private Color[] colors = new Color[] { Color.green, Color.red, Color.blue, Color.yellow };

    [SerializeField] private int numberPieces;

    [SerializeField] private Image levelCompletedPanel;

    // Start is called before the first frame update
    void Start()
    {
        actualColor = Colors.red;
    }

    public void ColorPiece(Piece piece)
    {
        piece.GetComponent<SpriteRenderer>().material.color = colors[((int)actualColor)];
        piece.mycolor = actualColor;
        piece.tag = "Piece";

        if (CheckPieces())
        {
            levelCompletedPanel.gameObject.SetActive(true);
        }
    }    

    public void ChangeActualColor(ColorButton button)
    {
        actualColor = button.mycolor;
    }

    private bool CheckPieces()
    {
        GameObject[] pieces = GameObject.FindGameObjectsWithTag("Piece");

        if(pieces.Length == numberPieces)
        {
            foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Piece"))
            {
                Piece piece = obj.GetComponent<Piece>();

                foreach (Piece a in piece.adjacentPieces)
                {
                    if (a.mycolor == piece.mycolor)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        return false;        
    }

    public void BackMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BackMain() {
        SceneManager.LoadScene("Main");
    }
}
