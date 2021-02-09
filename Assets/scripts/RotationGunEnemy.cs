using System;
using UnityEngine;

    public class RotationGunEnemy: BaseTank
    {
        [SerializeField] private Shoting _shoting;
        [SerializeField] Transform target;
       
       
        
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
            //shoting.Shot();
        }

    }