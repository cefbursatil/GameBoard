using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerVariables : MonoBehaviour
{
    // Start is called before the first frame update
    public float PlayerLife = 3;
    public float PlayerMaxLife = 10;
    public float PlayerSpeed = 2;
    public Vector3 PlayerDirection= new Vector3(0.5f, 0.5f, 0.5f);

    // Variables de cura y daño

    void Start()
    {
        //Verificamos Variables
        Debug.Assert(PlayerLife > 0, "LAS VIDAS TIENEN QUE SER MAYOR QUE 0 CUANDO COMIENZA EL OBJETO");
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    public void PlayerMovement()
    {
        transform.position += PlayerDirection * PlayerSpeed;
    }

    public void PlayerCure(float cure)
    {
        PlayerLife = Mathf.Min(PlayerLife + cure,PlayerMaxLife);
    }

    public void PlayerDamage(float damage)
    {
        PlayerLife = Mathf.Max(PlayerLife - damage, 0);
    }

}
