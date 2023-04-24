using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleMesh : MonoBehaviour
{
    private Mesh mesh;
    private Vector3[] vertices;
    private int[] triangles;

    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        vertices = new Vector3[] { new Vector3(0, 0, 0), new Vector3(1, 0, 0), new Vector3(0, 1, 0) };
        triangles = new int[] { 0, 1, 2 };

        mesh.vertices = vertices;
        mesh.triangles = triangles;
    }
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
