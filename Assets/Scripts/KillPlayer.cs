using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out Moneycollection moneycollection))
        {
            Debug.Log("���������");
            Destroy(moneycollection.gameObject);
        }
    }
}
