using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement: MonoBehaviour
{

    //Variables Posicion
    //public Vector3 initPosition = new Vector3(4, 2, 1);
    //Variables de Escala
    public Vector3 Initscale = new Vector3(1.1f, 1.1f, 1.1f);
    //Variables de Velocidad
    public float initialSpeedPlayer=1;
    float speedPlayer;
    float cameraAxis;
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = initPosition;
        transform.localScale = Initscale;
        speedPlayer = initialSpeedPlayer;

    }

    // Update is called once per frame
    void Update()
    {

        Move();
        RotatePlayer();
    }
    private void Move()
    {
        float ejeHorizontal = Input.GetAxis("Horizontal");
        float ejeVertical = Input.GetAxis("Vertical");
        transform.Translate(speedPlayer * Time.deltaTime * new Vector3(ejeHorizontal, 0, ejeVertical));
    }
    private void RotatePlayer()
    {
        cameraAxis += Input.GetAxis("Mouse X");
        Quaternion angulo = Quaternion.Euler(0, cameraAxis, 0);
        transform.localRotation = angulo;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Portals"))
        {
            if (transform.localScale == Initscale)
            {
                transform.localScale = Initscale * 2;
            }
            else
            {
                transform.localScale = Initscale;
            }
        }
        
    }


}
