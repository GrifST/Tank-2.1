using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoting : MonoBehaviour
{
    public Transform Firepoint;
    public GameObject ProjectilePrefab;
    private float _rateFireoffspeed;
    private float timer = 0f;
    private bool acessFire;

    private void Start()
    {
        GetRateFireAmunity();
    }

    private void GetRateFireAmunity()
    {
        _rateFireoffspeed = ProjectilePrefab.GetComponent<Projectiles>().RateFire;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > _rateFireoffspeed)
        {
            acessFire = true;
        }
    }

    public void Shoot()
    {
        if (acessFire)
        {
            GameObject Projectile = Instantiate(ProjectilePrefab, Firepoint.position, Firepoint.rotation);
            Rigidbody2D rb = Projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(Firepoint.up * ProjectilePrefab.GetComponent<Projectiles>().Speed, ForceMode2D.Impulse);
            acessFire = false;
            timer = 0;
        }
    }
}