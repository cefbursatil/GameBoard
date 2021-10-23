using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement: MonoBehaviour
{

    //Variables Posicion
    //public Vector3 initPosition = new Vector3(4, 2, 1);
    //Variables de Escala
    public Vector3 scale = new Vector3(1.1f, 1.1f, 1.1f);
    //Variables de Velocidad
    public float initialSpeedPlayer=1;
    float speedPlayer;
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = initPosition;
        transform.localScale = scale;
        speedPlayer = initialSpeedPlayer;

    }

    // Update is called once per frame
    void Update()
    {

        Move();
    }
    private void Move()
    {
        float ejeHorizontal = Input.GetAxis("Horizontal");
        float ejeVertical = Input.GetAxis("Vertical");
        transform.Translate(speedPlayer * Time.deltaTime * new Vector3(ejeHorizontal, 0, ejeVertical));
    }
}
