using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject prefPlayer;
    [SerializeField] private Transform spawnPlayer;
    [SerializeField] private Camcontrol cam;
    [SerializeField] private StatSetter _statSetter;


    private void Start()
    {
        GoGoTank();
    }

    private void GoGoTank()
    {
        PlayerCreate(prefPlayer).transform.position = spawnPlayer.position;
    }

    private GameObject PlayerCreate(GameObject pref)
    {
        var temp = Instantiate(pref);
        temp.GetComponentInChildren<HelthControl>().Setter = _statSetter;
        temp.GetComponentInChildren<HelthControl>().OnDead += OnPlayerDeda;
        cam.player = temp;
        return temp;
    }

    private void OnPlayerDeda(GameObject player)
    {
        player.GetComponentInChildren<HelthControl>().OnDead -= OnPlayerDeda;
        Destroy(player);
        GoGoTank();
    }
}