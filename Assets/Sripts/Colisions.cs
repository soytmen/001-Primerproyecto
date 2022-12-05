using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisions : MonoBehaviour
{
    public int Points;

    void Start()
    {
        Debug.Log($"Tu puntuaion inicial es 0");
    }


    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("coin"))
        {
            Destroy(other.gameObject);
            Points += 1;
            Debug.Log($"Llevas {Points}");
        }

        if (other.gameObject.name.Contains("obstacle"))
        {
            Points --;
            Debug.Log($"Llevas {Points}");
        }

    }
}
