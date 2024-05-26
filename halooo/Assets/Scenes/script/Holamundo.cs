using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Holamundo : MonoBehaviour
{
    int x;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        Debug.LogError("Algo salio muy mal");
        Debug.LogWarning("algo salio medianamente mal");
        print("algo salio mal");
       
    }

    // Update is called once per frame
    void Update()
    {
        x = x + 1;
        Debug.Log(x);

    }
}
