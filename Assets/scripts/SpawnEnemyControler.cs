using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyControler : MonoBehaviour
{

    [SerializeField] private GameObject prefEnemy;
    [SerializeField] private Transform spawnEnemy;
    [SerializeField] private StatSetter _statSetterEnemy;
    void Start()
    {
        EnemyGo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void EnemyGo()
    {
        Instantiate(prefEnemy).transform.position = spawnEnemy.position;
    }
    private GameObject EnemyCreate(GameObject pref)
    {
        var temp = Instantiate(pref);
        temp.GetComponentInChildren<HelthControl>().Setter = _statSetterEnemy;
        temp.GetComponentInChildren<HelthControl>().OnDead += OnEnemyDead;
        return temp;
    }
    private void OnEnemyDead(GameObject Enemy)
    {
        Enemy.GetComponentInChildren<HelthControl>().OnDead -= OnEnemyDead;
        Destroy(prefEnemy);
        EnemyGo();
    }
}
