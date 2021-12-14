using UnityEngine;
    
public class GoodBonus : InteractiveObject //InteractiveObject, IFlay, IFlicker, IEquatable<GoodBonus>
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player player = other.GetComponent<Player>();
            player.Speed *= 2;
            player.MovementSpeedWithBonus = 5f;
            Debug.Log("Get Bonus");
            Interaction();
            DestroyObject(gameObject, 0.2f);
        }
    }

    public void Message()
    {
        Debug.Log("Пора действовать, ведь уже 40!"); 
    }   
}