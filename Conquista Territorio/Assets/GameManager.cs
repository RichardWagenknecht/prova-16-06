using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject blockPrefab, player1Prefab, player2Prefab;

    public int linhas, colunas;

    public float spacing;

    private GameObject[,] bloco;

    private void Awake()
    {
        Instance = this;

        bloco = new GameObject[linhas, colunas];

        CriarGrade();
    }

}
