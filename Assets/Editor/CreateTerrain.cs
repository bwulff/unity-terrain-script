using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CreateOBJ : MonoBehaviour {

    [MenuItem("GameObject/3D Object/RetroMap")]
    static void Create()
    {
        TerrainData _terraindata = new TerrainData();
        int h = _terraindata.heightmapResolution;
        int w = _terraindata.heightmapResolution;
        float[,] data = new float[h, w];
        // using (var file = System.IO.File.OpenRead(aFileName))
        // using (var reader = new System.IO.BinaryReader(file))
        // {
        for (int y = 0; y < h; y++)
        {
            for (int x = 0; x < w; x++)
            {
                float v = Mathf.Sin(y) + Mathf.Cos(x);
                data[y, x] = v;
            }
           // }
        }
        _terraindata.SetHeights(0, 0, data);

        GameObject terrain = Terrain.CreateTerrainGameObject(_terraindata);
        Vector3 position = new Vector3(0, 0, 0);
        terrain.transform.position = position;
        terrain.name = "WulffTerrain";
    }
}
