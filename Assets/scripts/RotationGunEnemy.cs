using System;
using UnityEngine;

    public class RotationGunEnemy: BaseTank
    {
        [SerializeField] private Shoting _shoting;
        [SerializeField] Transform target;
        public float angle = 60;
        private float timer = 0f;
        public float reload = 3;
    private void Start()
        {
            target = FindObjectOfType<RotationGunPlayer>().transform;
        }

        private void Update()
        {
            
            base.RotationOnTarget(target.position,SpeedTorward);
            GetAngleAttack();
           

        }

        private void GetAngleAttack()
        {
        //логика наведения
        //если угол = угол атаки то 
        //

        if (Vector3.Angle(transform.forward, target.position - transform.position) <= angle)
        {
            
            timer += Time.deltaTime;
            if (timer > reload)
            {
                _shoting.Shoot();
                timer = 0;
            }
        }

    }

    }