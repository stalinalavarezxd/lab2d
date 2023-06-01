using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cofre : MonoBehaviour
{
    public GameObject cofre;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("!!Has Ganado!!");
            Destroy(gameObject, 0.2f);
            
        }
    }

}
