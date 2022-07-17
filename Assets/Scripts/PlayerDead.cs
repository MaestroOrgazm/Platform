using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDead : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out MoneyCollector moneyCollector))
        {
            Debug.Log("Поражение");
            Destroy(moneyCollector.gameObject);
        }
    }
}
