using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisions : MonoBehaviour
{
    public int Points;
    public Transform coins;
    public int totalCoins;
    void Start()
    {
        Debug.Log($"Tu puntuaion inicial es 0");
        totalCoins = coins.childCount;
    }


    void Update()
    {
        if (Points == -5)
        {
            Destroy(gameObject);
        }
        if (totalCoins <= 0)
        {
            Debug.Log($"You Win");
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("obstacle"))
        {
            Points--;
            Debug.Log($"Llevas {Points}");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("coin"))
        {
            Destroy(other.gameObject);
            Points += 1;
            Debug.Log($"Llevas {Points}");
            totalCoins--;
        }

       

    }
}
