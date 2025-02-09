using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject piecePrefab;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(piecePrefab, new Vector3(0, 0, -1), Quaternion.identity);
    }
}
