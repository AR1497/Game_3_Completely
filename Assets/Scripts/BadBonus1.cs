using UnityEngine;

public class BadBonus1 : InteractiveObject
{
    private NewGame NewGameStart1;

    void Start()
    {
        NewGameStart1 = new NewGame();  //Экземпляр класса
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            NewGameStart1.NewGameStart();
        }
    }
}
