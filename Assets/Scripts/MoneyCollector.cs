using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyCollector : MonoBehaviour
{
    private int _countMoney = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out CircleCollider2D circleCollider2D))
        {
            _countMoney++;
            Destroy(circleCollider2D.gameObject);
        }
    }
}
