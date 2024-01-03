using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlgFormation
{
    Vector2[,] config = { 
    {new Vector2(1,3), new Vector2(1, 2), new Vector2(1, 4), new Vector2(1, 1), new Vector2(1, 5) },
    {new Vector2(0,1), new Vector2(0, 3), new Vector2(1, 2), new Vector2(1, 3), new Vector2(1, 1) },
    {new Vector2(0,3), new Vector2(0, 2), new Vector2(0, 4), new Vector2(1, 3), new Vector2(1, 2) }};

    public List<Vector2> positionList = new List<Vector2>(8);

    public SlgFormation() { }
    public void Init(SlgConstants.TroopPath pathId)
    {
        positionList.Clear();
        for (int i = 0; i < config.GetLength(1); i++)
        {
            positionList.Add(config[(int)pathId, i]);
        }
    }
}
