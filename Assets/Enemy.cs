using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int hP = 100;

    void Start()
    {
        
    }


    void Update()
    {


        
    }
    void Dead()
    {
        //kaikenlaista animaatio paskaa
        Destroy(gameObject);
    }

    public void TakeDamage(int damage)
    {
        hP -= damage;
        if (hP <= 0)
        {
            Dead();
        }
    }
}
