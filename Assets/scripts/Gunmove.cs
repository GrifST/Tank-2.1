using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunmove : MonoBehaviour
{
    

    
    public Camera cam;






    Vector2 mousePos;
    private void Start()
    {
        cam = Camera.main;
    }
    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookDir = mousePos - new Vector2(transform.position.x, transform.position.y);
       
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;

        transform.rotation = Quaternion.Euler(0,0,angle);
    }
    
}
