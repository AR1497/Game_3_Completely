using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public sealed class GameController : MonoBehaviour, IDisposable
{
    private InteractiveObject[] _interactiveObjects;
    private GameObject collectBonuses;
    private GameObject gameDisplay;
    private Player player;

    private bool pause;
    private int countBonuses;

    private void Awake()
    {
        countBonuses = 2;
        Time.timeScale = 1;
        _interactiveObjects = FindObjectsOfType<InteractiveObject>();

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        collectBonuses = GameObject.FindGameObjectWithTag("CollectBonuses");
        gameDisplay = GameObject.FindGameObjectWithTag("GameDisplay");
        Debug.Log($"Трум пурум {player}");

        foreach(var _interactiveObject in _interactiveObjects)
        {
            _interactiveObject.onPointInGame += PrintOnDebug;
        }
    }

    void Start()
    {
        collectBonuses.SetActive(false);
    }

    private void Update()
    {
        if (player.countBonus == this.countBonuses) 
        {
            collectBonuses.SetActive(true);
            gameDisplay.SetActive(true);
            Time.timeScale = 0;  
        }
    }

    public void Dispose()
    {
        foreach (var o in _interactiveObjects)
        {
            o.onPointInGame -= PrintOnDebug;
            Destroy(o.gameObject);
        }
    }

    private void PrintOnDebug()
    {
        Debug.Log("Подобрали какой то бонус, вроде как");
    }
}
