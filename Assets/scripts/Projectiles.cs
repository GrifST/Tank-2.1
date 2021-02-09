using UnityEngine;

public class Projectiles : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] private float rateFire;
    public GameObject Hiteffect;

    public float Speed
    {
        get => speed;
        set => speed = value;
    }

    public float RateFire
    {
        get => rateFire;
        set => rateFire = value;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(Hiteffect, transform.position, Quaternion.identity);
        Destroy(effect, 1f);
        Destroy(gameObject);
    }

}
