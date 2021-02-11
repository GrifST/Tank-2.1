using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelthControl : MonoBehaviour
{
    [Header("Здоровье и Щиты")] [SerializeField]
    private float _maxHelthPoint = 100;

    [SerializeField] private float _currentHP;
    [SerializeField] private float _maxShieldPoint;
    [SerializeField] private float _currentSP;


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
