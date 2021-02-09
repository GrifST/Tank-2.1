using System;
using UnityEngine;


    public class RotationGunPlayer: BaseTank
    {
        [SerializeField] private string nameTank;
        private Vector2 mousePos;
        [SerializeField] private Camera cam;
    

   
        private void Update()
        {
            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            base.RotationOnTarget(mousePos,SpeedRotation);

        
        }

      
    }