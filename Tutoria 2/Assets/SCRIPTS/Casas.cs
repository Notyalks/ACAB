using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casas : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("bala"))
            {

            Destroy(collision.gameObject);

            }
    }
}
