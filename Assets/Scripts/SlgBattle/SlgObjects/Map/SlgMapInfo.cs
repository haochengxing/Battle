using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlgMapInfo : Singleton<SlgMapInfo>
{
    int gridX = 151;
    int gridZ = 31;
    int halfX;
    int halfZ;
    float gridSize = .5f;
    Vector3 centerPosition;
    Vector3 ldPosition;
    GameObject centerObject;
    Dictionary<int, Dictionary<int, Grid>> gridList;
    public SlgMapInfo()
    {
        centerObject = new GameObject("centerObject");
    }

    public void Init(int centerX, int centerY, int centerZ)
    {
        centerPosition.Set(centerX, centerY, centerZ);
        halfX = (gridX - 1) / 2;
        halfZ = (gridZ - 1) / 2;
        ldPosition.x = centerPosition.x - gridX * gridSize / 2 + gridSize / 2;
        ldPosition.y = centerPosition.y;
        ldPosition.z = centerPosition.z - gridZ * gridSize / 2 + gridSize / 2;
        centerObject.transform.position = centerPosition;
        gridList = new Dictionary<int, Dictionary<int, Grid>>();
        for (int x = 0; x < gridX; x++)
        {
            int curX = x - halfX;
            gridList.Add(curX, new Dictionary<int, Grid>());
            for (int z = 0; z < gridZ; z++)
            {
                int curZ = z - halfZ;
                Grid grid = new Grid();
                gridList[curX].Add(curZ, grid);
                grid.position.Set(ldPosition.x + x * gridSize, ldPosition.y, ldPosition.z + z * gridSize);
                grid.free = true;
            }
        }
    }
    public Vector3 GetGridPosition(int x,int z)
    {
        return gridList[x][z].position;
    }
}
