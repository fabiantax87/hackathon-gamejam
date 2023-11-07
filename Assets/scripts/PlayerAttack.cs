using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private Transform bulletPoint;
    [SerializeField] private GameObject bullet;

    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Attack();
        }
    }

    private void Attack()
    {
        bullet.transform.position = bulletPoint.position;
        bullet.GetComponent<Projectile>().SetDirection(Mathf.Sign(transform.localScale.x));
    }
}
