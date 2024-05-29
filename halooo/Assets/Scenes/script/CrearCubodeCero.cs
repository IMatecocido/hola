using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CrearCubodeCero : MonoBehaviour
{
    GameObject objtospawn;
    Vector3[] vertices = {
            new Vector3(0, 0, 0),//vertice 0
            new Vector3(1, 0, 0),//vertice 1
            new Vector3(1, 1, 0),//vertice 2  
            new Vector3(0, 1, 0),//vertice 3 
            new Vector3(0, 1, 1),//vertice 4
            new Vector3(1, 1, 1),//vertice 5
            new Vector3(1, 0, 1),//vertice 6
            new Vector3(0, 0, 1),//vertice 7
        };
    int[] triangulos ={
        0, 2, 1, //cara 1
        0, 3, 2,
        2, 3, 4, //cara 2
        2, 4, 5,
        1, 2, 5, //cara 3
        1, 5, 6,
        0, 7, 4, //cara 4
        0, 4, 3,
        5, 4, 7, //cara 5
        5, 7, 6,
        0, 6, 7, //cara 6
        0, 1, 6
        };
    // Start is called before the first frame update
    void Start()
    {
        objtospawn = new GameObject("cubito");
        objtospawn.AddComponent<MeshFilter>();
        var MeshFilter = objtospawn.GetComponent<MeshFilter>().mesh;
        MeshFilter.Clear();
        MeshFilter.vertices = vertices;
        MeshFilter.triangles = triangulos;
        MeshFilter.Optimize();
        MeshFilter.RecalculateNormals();
        objtospawn.AddComponent<BoxCollider>();
        var BoxCollider = objtospawn.GetComponent <BoxCollider>();
        BoxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);
        objtospawn.AddComponent<MeshRenderer>();
        var MeshRendererMaterial = objtospawn.GetComponent<MeshRenderer>().material;
        MeshRendererMaterial.color=Color.white;
        objtospawn.transform.position = Vector3.one;


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
