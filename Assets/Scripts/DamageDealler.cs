using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealler : MonoBehaviour
{
    [SerializeField] private float damage;
    [SerializeField] private string[] tags;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach (var tag in tags)
        {
            if (collision.CompareTag(tag))
            {
                if (collision.gameObject.TryGetComponent(out Health health))
                {
                    health.TakeDamage(damage);
                }

                Destroy(gameObject);
            }
        }
    }
}
