using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    enum EnemyTypes { steady, follow}
    [SerializeField] private EnemyTypes typeEnemy;
    [SerializeField] private GameObject player;
    [SerializeField] private int speedEnemy = 1;
    [SerializeField] private int speedtoLook = 1;


    // Start is called before the first frame update
    void Start()
    {
        switch (typeEnemy)
        {
            case EnemyTypes.steady:
                Debug.Log("Enemigo Quieto");
                break;
            case EnemyTypes.follow:
                Debug.Log("Enemigo sigue");
                break;
            default:
                Debug.Log("Enemigo no rota");
                break;
        }

        //Dibuja una linea
        Debug.DrawLine(transform.position, new Vector3(5, 0, 0), Color.red, 5);
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
        LookToPlayer();
    }

    private void MoveToPlayer()
    {
        if (typeEnemy == EnemyTypes.steady)
        {
            //NO movement
        }
        else if (typeEnemy == EnemyTypes.follow)
        {
            Vector3 directionPlayer = (player.transform.position - transform.position);
            //Moverse solo si distancia mayor a 2
            if (directionPlayer.magnitude > 2)
            {
                transform.position += speedEnemy * directionPlayer.normalized * Time.deltaTime;
            }
        }
    }
    private void LookToPlayer()
    {
        if (typeEnemy == EnemyTypes.steady)
        {
            Vector3 directionPlayer = (player.transform.position - transform.position).normalized;
            Quaternion rotationEnemy = Quaternion.LookRotation(directionPlayer);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotationEnemy, speedtoLook * Time.deltaTime);

        }
        else if(typeEnemy == EnemyTypes.follow)
        {
            Vector3 directionPlayer = (player.transform.position - transform.position).normalized;
            Quaternion rotationEnemy = Quaternion.LookRotation(directionPlayer);
            transform.rotation = rotationEnemy;
        }
    }
}
