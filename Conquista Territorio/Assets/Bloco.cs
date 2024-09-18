using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour


{
  public static Bloco instance; 
  
    private bool blocoConquista;
    private SpriteRenderer spriteRenderer;
    private int jogadorDono;

    private void Awake()
    {
        instance = this;
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.white;

    }


}
