using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedAcc : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player player = other.GetComponent<Player>();
            player.Speed *= 2;
            DestroyObject(gameObject, 0.2f);
        }
    }
}
