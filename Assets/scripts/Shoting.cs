using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoting : MonoBehaviour
{


    public Transform Firepoint;
    public GameObject PlazmPrefab;
    public GameObject ShellPrefab;
    public float DpsPlasm = 0.5f;
    public float DpsShell = 0.9f;
    public float Plazmforce = 20f;
    public float Shellforce = 20f;
    private float _rateofspeed;
    void Update()
    {
      

        if (_rateofspeed <= DpsPlasm)
        {
            _rateofspeed += Time.deltaTime;
        }
   
        if (Input.GetMouseButton(0) & _rateofspeed > DpsPlasm)
        {
            _rateofspeed = 0;

            Shoot();
        }

        if (_rateofspeed <= DpsShell)
        {
            _rateofspeed += Time.deltaTime;
        }

        if (Input.GetMouseButton(1) & _rateofspeed > DpsShell)
        {
            _rateofspeed = 0;

            Shoot2();
        }

    }
    void Shoot()
    {
        GameObject Plazm = Instantiate(PlazmPrefab, Firepoint.position, Firepoint.rotation);
        Rigidbody2D rb = Plazm.GetComponent<Rigidbody2D>();
        rb.AddForce(Firepoint.up * Plazmforce, ForceMode2D.Impulse);
    }
    void Shoot2()
    {
        GameObject Shell = Instantiate(ShellPrefab, Firepoint.position, Firepoint.rotation);
        Rigidbody2D rb = Shell.GetComponent<Rigidbody2D>();
        rb.AddForce(Firepoint.up * Shellforce, ForceMode2D.Impulse);
    }
}
