using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    SlgWarPlay slgWar;
    float atkTime = 5f;
    bool atk = false;
    // Start is called before the first frame update
    void Start()
    {
        slgWar = new SlgWarPlay();
        slgWar.Init();
    }

    // Update is called once per frame
    void Update()
    {
        slgWar.Update(Time.deltaTime);
        if (atk==false&&Time.realtimeSinceStartup> atkTime)
        {
            atk = true;
            slgWar.StartAtk();
        }
    }
}
