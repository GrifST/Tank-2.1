using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelthControl : MonoBehaviour
{
    [Header("Здоровье и Щиты")] 
    [SerializeField] private float _maxHelthPoint;  
    [SerializeField] private float _maxShieldPoint;
    private float _currentSP;
    private float _currentHP;

    private void Start()
    {
        _currentSP = _maxShieldPoint;
        _currentHP = _maxHelthPoint;
        
    }

    void Update()
    {
      
    }

 
    public void TakeDamage(float damage)
    {
        _currentSP -= damage;

        if (_currentSP <= 0)
        {
            _currentHP -= damage;


            if (_currentHP <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
