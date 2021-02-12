using System;
using UnityEngine;

public class HelthControl : MonoBehaviour
{
    [SerializeField] private GameObject body;
    public Action<GameObject> OnDead;
    [SerializeField] private StatSetter _statSetter;

    [Header("Здоровье и Щиты")] [SerializeField]
    private float _maxHelthPoint;

    [SerializeField] private float _maxShieldPoint;
    private float _currentSP;
    private float _currentHP;

    public StatSetter Setter
    {
        get => _statSetter;
        set => _statSetter = value;
    }

    private void Start()
    {
        _currentSP = _maxShieldPoint;
        _currentHP = _maxHelthPoint;
    }


    public void TakeDamage(float damage)
    {
        _currentSP -= damage;

        if (_currentSP <= 0)
        {
          
            _currentHP -= damage;
            Setter.SetHP(_currentHP, _maxHelthPoint);

            if (_currentHP <= 0)
            {
                Sucid();
            }
        }
    }

    private void Sucid()
    {
        OnDead?.Invoke(body);
    }
}