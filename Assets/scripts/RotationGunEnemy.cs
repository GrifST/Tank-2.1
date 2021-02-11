using System;
using UnityEngine;

    public class RotationGunEnemy: BaseTank
    {
        [SerializeField] private Shoting _shoting;
        [SerializeField] Transform target;
        [SerializeField] private float angle = 360;
        public float timer = 0f;
        public float _rateFireoffspeed = 3f;
        private bool acessFire;
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
            if (timer >= _rateFireoffspeed)
            {
                timer = 0;
                acessFire = true;

                if (acessFire)
                {

                    _shoting.Shoot();

                }
            }
           
        }

    }

    }