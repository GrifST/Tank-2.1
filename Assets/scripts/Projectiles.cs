using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    public GameObject Hiteffect;


    private void OnCollisionEnter2D(Collision2D collision)
    {


        GameObject effect = Instantiate(Hiteffect, transform.position, Quaternion.identity);
        Destroy(effect, 1f);
        Destroy(gameObject);

    }

}
