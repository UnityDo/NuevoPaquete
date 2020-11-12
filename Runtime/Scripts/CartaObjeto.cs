using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Carta", menuName = "Cartas/Carta", order = 1)]
public class CartaObjeto : ScriptableObject
{
    public enum Palo { Bastos, Copas, Espadas, Oros }
    public string nombre;
    public Palo palo = Palo.Bastos;
    public int numero;
    public float valor;
    public bool esFigura;
    public Sprite sprite;
    public Sprite spriteDorso;

    public CartaObjeto(string nombre, Palo palo, int numero, float valor, bool esFigura, Sprite sprite, Sprite spriteDorso)
    {
        this.nombre = nombre;
        this.palo = palo;
        this.numero = numero;
        this.valor = valor;
        this.esFigura = esFigura;
        this.sprite = sprite;
        this.spriteDorso = spriteDorso;
    }
}
