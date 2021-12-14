using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public abstract class Player : MonoBehaviour
{
    public float Speed = 3.0f;
    private Rigidbody _rigidbody;
    private float _speedRotate = 70f;
    private Transform _target;

    public Text textCountBonuses;
    private GoodBonus goodBonus;
    public int countBonus;
    public float MovementSpeedWithBonus { get; set; }
    private float oldSpeedP;

    void Start()
    {
        oldSpeedP = Speed;
        if (textCountBonuses == null)
        {
            throw new Exception("Не перетащили объект textCountBonuses");
        }
        textCountBonuses.text = "Таблетки: ";

        Debug.Log("Количество 'к' в строке:");
        Debug.Log("Кар кар кар".CharCount('к'));
        
        List<int> list = new List<int>() {7, 8, 9, 1, 7, 2, 9};
        var dupList = list.NumberOfDuplicateListItems();
        foreach (var item in dupList)
        {
            Debug.Log($"{item.Key} повторяется {item.Value} раз");
        }

        _rigidbody = GetComponent<Rigidbody>();
    }

    protected void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        _rigidbody.AddForce(movement * Speed);
    }

    protected void GetBonus()
    {
        textCountBonuses.text = $"Таблетки: {countBonus}";
    }

    protected void CheckedSpeedP()
    {
        if (MovementSpeedWithBonus > 0)
        {
            Invoke("SetSpeedP", MovementSpeedWithBonus);
        }
    }

    private void SetSpeedP()
    {
        MovementSpeedWithBonus = 0;
        Speed = oldSpeedP;
    }
}
