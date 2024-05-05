using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Update_MEsh : MonoBehaviour
{
    public void CutMesh(Vector3[] newVertices, int[] newTriangles)
    {
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        if (meshFilter == null)
        {
            Debug.LogError("MeshFilter component not found!");
            return;
        }

        Mesh newMesh = new Mesh();
        newMesh.vertices = newVertices;
        newMesh.triangles = newTriangles;

        // Recalculate normals to ensure lighting is correct
        newMesh.RecalculateNormals();

        // Assign the new mesh to the object
        meshFilter.mesh = newMesh;

        // Optionally update collider
        Collider collider = GetComponent<Collider>();
        if (collider != null)
        {
            // Update collider to match new mesh
            collider.enabled = false;
            collider.enabled = true;
        }
    }

}

