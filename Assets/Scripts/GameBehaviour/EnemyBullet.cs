using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private int bulletDamage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Boundary")
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "Player")
        {
            PlayerHealthManager.Instance.TakeDamage(bulletDamage);
            Destroy(this.gameObject);
        }
    }

    public void SetBulletDamage(int damage)
    {
        bulletDamage = damage;
    }
}
