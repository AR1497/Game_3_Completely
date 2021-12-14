using UnityEngine;

public class CollectNecessary : InteractiveObject
{
    private int valueBonus = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player player = other.GetComponent<Player>();
            player.countBonus += valueBonus;
            Interaction();
            DestroyObject(gameObject, 0.2f);
        }
    }

    public void Message()
    {
        Debug.Log("Точно, уже 40!");
    }
}
