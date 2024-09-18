using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject blockPrefab, player1Prefab, player2Prefab;

    public int linhas, colunas;

    public float spacing;

    int blocosConquistados;

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
                Vector2 position = new Vector3(i * spacing, j * spacing); // Calcula a posição de cada bloco

                GameObject blockPrefabtemp = Instantiate(blockPrefab, position, Quaternion.identity); // Instancia o bloco na posição calculada

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
    void ConquistarTerritorio()
    {
        blocosConquistados++;

        if (blocosConquistados == linhas * colunas)
        {
            int territorioPlayer1 = 0, territorioPlayer2 = 0;
            int dono = Bloco.instance.PegarJogadorDono();

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (dono == 1)
                    {
                        territorioPlayer1++;
                    }
                    else
                    {
                        territorioPlayer2++;
                    }
                }
            }
            FimDeJogo(territorioPlayer1, territorioPlayer2);
        }

    }
    void FimDeJogo(int territorioPlayer1, int territorioPlayer2)
    {
        string vencedor;

        if (territorioPlayer1 > territorioPlayer2)
        {
            vencedor = "Vencedor Jogador 1";
        }
        else if (territorioPlayer2 > territorioPlayer1)
        {
            vencedor = "Vencedor Jogador 2";
        }
        else
        {
            vencedor = "Impate";
        }
        Debug.Log(vencedor);
    }

}
