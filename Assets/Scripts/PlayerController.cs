using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    //Otros Objetos
    public GameObject swordPlayer;
    //Variables Generales
    public int playerCoins = 3;
    //Variables Posicion
    public Vector3 initPosition = new Vector3(4, 2, 1);
    //Variables de Escala
    public Vector3 scale = new Vector3(0.5f, 0.5f, 0.5f);
    //Variables de Velocidad
    public float initialSpeedPlayer=1;
    float speedPlayer;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = initPosition;
        transform.localScale = scale;
        speedPlayer = initialSpeedPlayer;

        // Detiene la ejecución
        //Debug.Break();
        Debug.Log(swordPlayer.GetComponent<SwordController>().GetSwordName());
        swordPlayer.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += new Vector3(-0.001f, 0f, 0f) * speedPlayer;
    }
}
