﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Speed;
    public float StopDist;
    public float RetreatDist;
    public Transform Player;
    private Rigidbody2D rb;
   [SerializeField] private float searchTimer;
   [SerializeField] private float setTimer = 10f;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();

        //тэги это прохо. ты можешь огрести кучу проблем просто из за неверного имени.
        //рекомендую использовать поиск по типу компонента

        //Player = GameObject.FindGameObjectWithTag("Player").transform;

    }

   
    void Update()
    {
        
        if(searchTimer < setTimer && Player==null)
        {
             Player = FindObjectOfType<RotationGunPlayer>().transform;
             searchTimer = setTimer;
        }
        searchTimer -= Time.deltaTime;
        
        if (Player != null)
        {
            SearchPlayer();
        }
    }

    private  void SearchPlayer()
    {
       
        Vector3 direction = Player.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rb.rotation = angle;
            var dist = Vector2.Distance(transform.position, Player.position);

            if (dist > StopDist)
            {
                transform.position = Vector2.MoveTowards(transform.position, Player.position, Speed * Time.deltaTime);
            }
            else if (dist < StopDist && (dist > RetreatDist))
            {
                transform.position = Player.position;
            }
            else if (dist < RetreatDist)
            {
                transform.position = Vector2.MoveTowards(transform.position, Player.position, -Speed * Time.deltaTime);
            }
    }
}
