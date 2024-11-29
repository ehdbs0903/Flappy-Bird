using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeEvent : MonoBehaviour
{
    public GameObject endUI;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Game Over");
            endUI.SetActive(true);
        }
    }
}