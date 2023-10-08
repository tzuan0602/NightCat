using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grilmap : MonoBehaviour
{
    public int gridSizeX = 10; // X軸上的格子數量
    public int gridSizeY = 20; // Z軸上的格子數量
    public float cellSize = 1.0f; // 格子的大小

    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        Mesh mesh = meshFilter.mesh;
        mesh.Clear();

        Vector3[] vertices = new Vector3[(gridSizeX + 1) * (gridSizeY + 1)];
        Vector2[] uv = new Vector2[vertices.Length];

        for (int y = 0, i = 0; y <= gridSizeY; y++)
        {
            for (int x = 0; x <= gridSizeX; x++)
            {
                vertices[i] = new Vector3(x * cellSize, 0, y * cellSize);
                uv[i] = new Vector2((float)x / gridSizeX, (float)y / gridSizeY);
                i++;
            }
        }

        int[] triangles = new int[gridSizeX * gridSizeY * 6];

        for (int ti = 0, vi = 0, y = 0; y < gridSizeY; y++, vi++)
        {
            for (int x = 0; x < gridSizeX; x++, ti += 6, vi++)
            {
                triangles[ti] = vi;
                triangles[ti + 3] = triangles[ti + 2] = vi + 1;
                triangles[ti + 4] = triangles[ti + 1] = vi + gridSizeX + 1;
                triangles[ti + 5] = vi + gridSizeX + 2;
            }
        }

        mesh.vertices = vertices;
        mesh.uv = uv;
        mesh.triangles = triangles;

        mesh.RecalculateNormals();
    }
}
