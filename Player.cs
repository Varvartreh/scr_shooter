using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int coins = 0;
    public GameObject bullet;
    public Transform shoot;
    public float shootTimer;
    void Update()
    {
        Move();
        Shoot();
    }
    void Move()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 pos = Input.mousePosition;
            Vector2 converted_pos = Camera.main.ScreenToWorldPoint(pos);
            transform.position = converted_pos;
        }

    }
    void Shoot(){
        if(shootTimer<=0){
            shootTimer -= Time.deltaTime;
            Instantiate(bullet, shoot.position, shoot.rotation);
        }
    }
}
