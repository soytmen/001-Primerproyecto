using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisions : MonoBehaviour
{
    public int Points;


    //contador +1 cuando ciges una moneda, si chocas con un objeto -1,si llegas a -10 game over.
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Tu puntuaion inicial es 0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        
    }
}
