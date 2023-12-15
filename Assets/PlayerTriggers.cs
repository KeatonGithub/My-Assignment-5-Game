using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggers : MonoBehaviour
{
    public WinLose winLoseScript;
    void Update()
    {
      if(transform.position.y < -12.0f)
        {
            winLoseScript.LoseLevel();
        }
    }
}
