using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

internal sealed class TakeBonus : GoodBonus
{
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Flag"))
        {
            Invoke("Restart", 0.1f);
        }
    }
}
