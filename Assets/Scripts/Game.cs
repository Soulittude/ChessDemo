using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject piecePrefab;

    //Positions and teams
    private GameObject[,] positions = new GameObject[8, 8];
    private GameObject[] playerWhite = new GameObject[16];
    private GameObject[] playerBlack = new GameObject[16];

    private string currentPlayer = "white";

    private bool gameOver = false;

    void Start()
    {
        playerWhite = new GameObject[] {
            Create("white_rook",0,0), Create("white_knight",1,0),
            Create("white_bishop",2,0), Create("white_queen",3,0), Create("white_king",3,0),
            Create("white_bishop",5,0), Create("white_knight",6,0), Create("white_rook",7,0),
            Create("white_pawn",0,1), Create("white_pawn",1,1), Create("white_pawn",2,1),
            Create("white_pawn",3,1), Create("white_pawn",4,1), Create("white_pawn",5,1),
            Create("white_pawn",6,1), Create("white_pawn",7,1) };
    }
}
