using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground
{
    public class Position
    {
        public int posX;
        public int posY;
        public int length;
        public int width;
    }

    public int pathHeight;
    public List<Position> positionList = new List<Position>();

    public static List<Ground> DataList = new List<Ground>();
    public static void Init()
    {
        if (DataList.Count>0)
        {
            return;
        }
        Ground ground = new Ground();
        ground.pathHeight = 13;
        ground.positionList.Add(new Position() { posX = 1, posY = 1, length = 3, width = 7 });
        ground.positionList.Add(new Position() { posX = 4, posY = 6, length = 2, width = 7 });
        ground.positionList.Add(new Position() { posX = 5, posY = 0, length = 2, width = 6 });
        ground.positionList.Add(new Position() { posX = 7, posY = 3, length = 4, width = 6 });
        DataList.Add(ground);

        ground = new Ground();
        ground.pathHeight = 5;
        ground.positionList.Add(new Position() { posX = 4, posY = 1, length = 3, width = 3 });
        ground.positionList.Add(new Position() { posX = 6, posY = 3, length = 3, width = 3 });
        ground.positionList.Add(new Position() { posX = 7, posY = 0, length = 3, width = 3 });
        DataList.Add(ground);

        ground = new Ground();
        ground.pathHeight = 13;
        ground.positionList.Add(new Position() { posX = 1, posY = 5, length = 3, width = 7 });
        ground.positionList.Add(new Position() { posX = 4, posY = 0, length = 2, width = 7 });
        ground.positionList.Add(new Position() { posX = 5, posY = 7, length = 2, width = 6 });
        ground.positionList.Add(new Position() { posX = 7, posY = 3, length = 4, width = 6 });
        DataList.Add(ground);
    }
}
