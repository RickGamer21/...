using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 10;
    GameObject FireballPrefab;
    Transform attackPoint;
    int coins;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(FireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Çäîðîâüå èãðîêà: " + health);
    }
    public void CollectCoins()
    {
        coins++;
        print("Ñîáðàííûå ìîíåòû: " + coins);
    }
}
