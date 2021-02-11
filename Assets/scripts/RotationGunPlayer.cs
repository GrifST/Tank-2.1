using System;
using UnityEngine;


    public class RotationGunPlayer: BaseTank
    {
        private Vector2 mousePos;
        [SerializeField] private Camera cam;
    

   
        private void Update()
        {
            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            base.RotationOnTarget(mousePos,SpeedRotation);

        
        }

      
    }