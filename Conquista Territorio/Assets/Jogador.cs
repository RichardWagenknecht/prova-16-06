using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    private const float velocidade = 5.0f;
    [SerializeField] private bool jogador1;
    [SerializeField] private Color corDoJogador;
    private Vector2 direcao;


    void Update()
    {
        if (jogador1)
        {
            if (Input.GetKey(KeyCode.A))
            {
                direcao.x = -1;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                direcao.x = 1;
            }
            else if (Input.GetKey(KeyCode.W))
            {
                direcao.y = 1;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                direcao.y = -1;
            }
        }

    }