using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class CreaCartasObjetos : MonoBehaviour
{
    CartaObjeto[] Baraja=new CartaObjeto[40];
    public Sprite[] spriteCartaObjetos;
    public Sprite dorso;
    public List<CartaObjeto> BarajaObjetos;
    // Start is called before the first frame update
    void Start()
    {
        GameObject imagen = new GameObject();
        imagen.AddComponent<Image>();
        imagen.GetComponent<Image>().sprite = BarajaObjetos[0].sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [ContextMenu ("CreaCartas")]
    void CreaCartas()
    {
        Baraja[0] = new CartaObjeto("As de bastos", CartaObjeto.Palo.Bastos, 1, 1, false, spriteCartaObjetos[0], dorso);
        Baraja[1] = new CartaObjeto("Dos de bastos", CartaObjeto.Palo.Bastos, 2, 2, false, spriteCartaObjetos[1], dorso);
        Baraja[2] = new CartaObjeto("Tres de bastos", CartaObjeto.Palo.Bastos, 3, 3, false, spriteCartaObjetos[2], dorso);
        Baraja[3] = new CartaObjeto("Cuatro de bastos", CartaObjeto.Palo.Bastos, 4, 4, false, spriteCartaObjetos[3], dorso);
        Baraja[4] = new CartaObjeto("Cinco de bastos", CartaObjeto.Palo.Bastos, 5, 5, false, spriteCartaObjetos[4], dorso);
        Baraja[5] = new CartaObjeto("Seis de bastos", CartaObjeto.Palo.Bastos, 6, 6, false, spriteCartaObjetos[5], dorso);
        Baraja[6] = new CartaObjeto("Siete de bastos", CartaObjeto.Palo.Bastos, 7, 7, false, spriteCartaObjetos[6], dorso);
        Baraja[7] = new CartaObjeto("Sota de bastos", CartaObjeto.Palo.Bastos, 10, 10, true, spriteCartaObjetos[7], dorso);
        Baraja[8] = new CartaObjeto("Caballo de bastos", CartaObjeto.Palo.Bastos, 11, 11, true, spriteCartaObjetos[8], dorso);
        Baraja[9] = new CartaObjeto("Rey de bastos", CartaObjeto.Palo.Bastos, 12, 12, true, spriteCartaObjetos[9], dorso);
        //Copas
        Baraja[10] = new CartaObjeto("As de copas", CartaObjeto.Palo.Copas, 1, 1, false, spriteCartaObjetos[10], dorso);
        Baraja[11] = new CartaObjeto("Dos de copas", CartaObjeto.Palo.Copas, 2, 2, false, spriteCartaObjetos[11], dorso);
        Baraja[12] = new CartaObjeto("Tres de copas", CartaObjeto.Palo.Copas, 3, 3, false, spriteCartaObjetos[12], dorso);
        Baraja[13] = new CartaObjeto("Cuatro de copas", CartaObjeto.Palo.Copas, 4, 4, false, spriteCartaObjetos[13], dorso);
        Baraja[14] = new CartaObjeto("Cinco de copas", CartaObjeto.Palo.Copas, 5, 5, false, spriteCartaObjetos[14], dorso);
        Baraja[15] = new CartaObjeto("Seis de copas", CartaObjeto.Palo.Copas, 6, 6, false, spriteCartaObjetos[15], dorso);
        Baraja[16] = new CartaObjeto("Siete de copas", CartaObjeto.Palo.Copas, 7, 7, false, spriteCartaObjetos[16], dorso);
        Baraja[17] = new CartaObjeto("Sota de copas", CartaObjeto.Palo.Copas, 10, 10, true, spriteCartaObjetos[17], dorso);
        Baraja[18] = new CartaObjeto("Caballo de copas", CartaObjeto.Palo.Copas, 11, 11, true, spriteCartaObjetos[18], dorso);
        Baraja[19] = new CartaObjeto("Rey de copas", CartaObjeto.Palo.Copas, 12, 12, true, spriteCartaObjetos[19], dorso);
        //Espadas
        Baraja[20] = new CartaObjeto("As de espadas", CartaObjeto.Palo.Espadas, 1, 1, false, spriteCartaObjetos[20], dorso);
        Baraja[21] = new CartaObjeto("Dos de espadas", CartaObjeto.Palo.Espadas, 2, 2, false, spriteCartaObjetos[21], dorso);
        Baraja[22] = new CartaObjeto("Tres de espadas", CartaObjeto.Palo.Espadas, 3, 3, false, spriteCartaObjetos[22], dorso);
        Baraja[23] = new CartaObjeto("Cuatro de espadas", CartaObjeto.Palo.Espadas, 4, 4, false, spriteCartaObjetos[23], dorso);
        Baraja[24] = new CartaObjeto("Cinco de espadas", CartaObjeto.Palo.Espadas, 5, 5, false, spriteCartaObjetos[24], dorso);
        Baraja[25] = new CartaObjeto("Seis de espadas", CartaObjeto.Palo.Espadas, 6, 6, false, spriteCartaObjetos[25], dorso);
        Baraja[26] = new CartaObjeto("Siete de espadas", CartaObjeto.Palo.Espadas, 7, 7, false, spriteCartaObjetos[26], dorso);
        Baraja[27] = new CartaObjeto("Sota de espadas", CartaObjeto.Palo.Espadas, 10, 10, true, spriteCartaObjetos[27], dorso);
        Baraja[28] = new CartaObjeto("Caballo de espadas", CartaObjeto.Palo.Espadas, 11, 11, true, spriteCartaObjetos[28], dorso);
        Baraja[29] = new CartaObjeto("Rey de espadas", CartaObjeto.Palo.Espadas, 12, 12, true, spriteCartaObjetos[29], dorso);
        //Oros
        Baraja[30] = new CartaObjeto("As de oros", CartaObjeto.Palo.Oros, 1, 1, false, spriteCartaObjetos[30], dorso);
        Baraja[31] = new CartaObjeto("Dos de oros", CartaObjeto.Palo.Oros, 2, 2, false, spriteCartaObjetos[31], dorso);
        Baraja[32] = new CartaObjeto("Tres de oros", CartaObjeto.Palo.Oros, 3, 3, false, spriteCartaObjetos[32], dorso);
        Baraja[33] = new CartaObjeto("Cuatro de oros", CartaObjeto.Palo.Oros, 4, 4, false, spriteCartaObjetos[33], dorso);
        Baraja[34] = new CartaObjeto("Cinco de oros", CartaObjeto.Palo.Oros, 5, 5, false, spriteCartaObjetos[34], dorso);
        Baraja[35] = new CartaObjeto("Seis de oros", CartaObjeto.Palo.Oros, 6, 6, false, spriteCartaObjetos[35], dorso);
        Baraja[36] = new CartaObjeto("Siete de oros", CartaObjeto.Palo.Oros, 7, 7, false, spriteCartaObjetos[36], dorso);
        Baraja[37] = new CartaObjeto("Sota de oros", CartaObjeto.Palo.Oros, 10, 10, true, spriteCartaObjetos[37], dorso);
        Baraja[38] = new CartaObjeto("Caballo de oros", CartaObjeto.Palo.Oros, 11, 11, true, spriteCartaObjetos[38], dorso);
        Baraja[39] = new CartaObjeto("Rey de oros", CartaObjeto.Palo.Oros, 12, 12, true, spriteCartaObjetos[39], dorso);



        for (int i = 0; i < Baraja.Length; i++)
        {
           // CartaObjeto carta = (CartaObjeto)ScriptableObject.CreateInstance("CartaObjeto");
            AssetDatabase.CreateAsset(Baraja[i], "Assets/Resources/Cartas/" + Baraja[i].nombre + ".asset");
            AssetDatabase.SaveAssets();
        }

       
    }
}
