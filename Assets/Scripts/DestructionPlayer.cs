using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionPlayer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out MoneyCollector moneyCollector))
        {
            Destroy(moneyCollector.gameObject);
        }
    }
}
