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
    void CriarGrade()
    {
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Vector2 position = new Vector3(i * spacing, j * spacing); // Calcula a posi��o de cada bloco

                GameObject blockPrefabtemp = Instantiate(blockPrefab, position, Quaternion.identity); // Instancia o bloco na posi��o calculada

                bloco[i, j] = blockPrefabtemp; // Armazena o bloco na matriz
            }
        }

        Vector3 deslocamento = new Vector3(spacing, 0, 0);

        Vector3 posicaoPlayer1 = new Vector3((linhas * spacing)/2, (colunas  * spacing) /2 , 0) + deslocamento;
        Vector3 posicaoPlayer2 = new Vector3((linhas * spacing) / 2, (colunas * spacing) /2 , 0) + -deslocamento;

        Instantiate(player1Prefab, posicaoPlayer1, Quaternion.identity);
        Instantiate(player2Prefab, posicaoPlayer2, Quaternion.identity);

        Camera.main.transform.position = new Vector3 (((linhas - 1)*spacing)/2, ((linhas - 1) * spacing) /2, -10);
        Camera.main.orthographicSize = (colunas * linhas) / 4;
    }


}
