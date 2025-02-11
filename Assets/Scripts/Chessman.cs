using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Chessman : MonoBehaviour
{
    [Header("References")]

    public GameObject controller;
    public GameObject movePlate;

    //Positions
    private int xBoard = -1;
    private int yBoard = -1;


    private string player;

    //References to piece sprites
    public Sprite whiteKing, whiteQueen, whiteRook, whiteBishop, whiteKnight, whitePawn;
    public Sprite blackKing, blackQueen, blackRook, blackBishop, blackKnight, blackPawn;

    public void Activate()
    {
        controller = GameObject.FindGameObjectWithTag("GameController");

        SetCoords();

        switch (this.name)
        {
            case "whiteKing": this.GetComponent<SpriteRenderer>().sprite = whiteKing; break;
            case "whiteQueen": this.GetComponent<SpriteRenderer>().sprite = whiteQueen; break;
            case "whiteRook": this.GetComponent<SpriteRenderer>().sprite = whiteRook; break;
            case "whiteBishop": this.GetComponent<SpriteRenderer>().sprite = whiteBishop; break;
            case "whiteKnight": this.GetComponent<SpriteRenderer>().sprite = whiteKnight; break;
            case "whitePawn": this.GetComponent<SpriteRenderer>().sprite = whitePawn; break;

            case "blackKing": this.GetComponent<SpriteRenderer>().sprite = blackKing; break;
            case "blackQueen": this.GetComponent<SpriteRenderer>().sprite = blackQueen; break;
            case "blackRook": this.GetComponent<SpriteRenderer>().sprite = blackRook; break;
            case "blackBishop": this.GetComponent<SpriteRenderer>().sprite = blackBishop; break;
            case "blackKnight": this.GetComponent<SpriteRenderer>().sprite = blackKnight; break;
            case "blackPawn": this.GetComponent<SpriteRenderer>().sprite = blackPawn; break;
        }
    }

    public void SetCoords()
    {
        float x = xBoard;
        float y = yBoard;

        float coordMultiplier = 0.66f;
        float coordOffset = -2.3f;

        x *= coordMultiplier;
        y *= coordMultiplier;

        x += coordOffset;
        y += coordOffset;

        this.transform.position = new Vector3(x, y, -1);
    }

    public int GetXBoard()
    {
        return xBoard;
    }

    public int GetYBoard()
    {
        return yBoard;
    }

    public void SetXBoard(int x)
    {
        xBoard = x;
    }

    public void SetYBoard(int y)
    {
        yBoard = y;
    }
}
