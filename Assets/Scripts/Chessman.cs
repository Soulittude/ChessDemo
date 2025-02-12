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

    private void OnMouseUp()
    {
        DestroyMovePlates();

        InitiateMovePlates();
    }

    public void DestroyMovePlates()
    {
        GameObject[] movePlates = GameObject.FindGameObjectsWithTag("MovePlate");

        for (int i = 0; i < movePlates.Length; i++)
        {
            Destroy(movePlates[i]);
        }
    }

    public void InitiateMovePlates()
    {
        switch (this.name)
        {
            case "whiteQueen":
            case "blackQueen":
                LineMovePlate(1, 0);
                LineMovePlate(0, 1);
                LineMovePlate(1, 1);
                LineMovePlate(-1, 0);
                LineMovePlate(0, -1);
                LineMovePlate(-1, -1);
                LineMovePlate(-1, 1);
                LineMovePlate(1, -1);
                break;

            case "whiteKnight":
            case "blackKnight":
                LMovePlate();
                break;

            case "whiteBishop":
            case "blackBishop":
                LineMovePlate(1, 1);
                LineMovePlate(1, -1);
                LineMovePlate(-1, 1);
                LineMovePlate(-1, -1);
                break;

            case "whiteKing":
            case "blackKing":
                SurroundMovePlate();
                break;

            case "whiteRook":
            case "blackRook":
                LineMovePlate(1, 0);
                LineMovePlate(0, 1);
                LineMovePlate(-1, 0);
                LineMovePlate(0, -1);
                break;

            case "whitePawn":
                PawnMovePlate(xBoard, yBoard - 1);
                break;
            case "blackPawn":
                PawnMovePlate(xBoard, yBoard + 1);
                break;
        }
    }

    private void PawnMovePlate(int xBoard, int v)
    {
        throw new NotImplementedException();
    }

    private void SurroundMovePlate()
    {
        throw new NotImplementedException();
    }

    private void LMovePlate()
    {
        throw new NotImplementedException();
    }

    private void LineMovePlate(int v1, int v2)
    {
        throw new NotImplementedException();
    }
}
