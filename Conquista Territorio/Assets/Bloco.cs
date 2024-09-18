using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEngine;

public class Bloco : MonoBehaviour


{
  
    private bool conquistado = false;
    private SpriteRenderer spriteRenderer;
    private int jogadorDono;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        AtualizarCor(Color.white);
    }

    public void AlterarConquistas(bool jogador1, Color corDoJogador)
    {
        conquistado=true;
        AtualizarCor(corDoJogador);
    
        if (jogador1)
        {
            jogadorDono = 1;
            GameManager.Instance.NotificarConquista(1);

        }
    }
    


}
