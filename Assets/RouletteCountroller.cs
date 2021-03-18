using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class RouletteCountroller : MonoBehaviour
{
    float rotSpeed = 0.0f;

    private static object GetDebuggerDisplay()
    {
        throw new NotImplementedException();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 8.0f;}
        transform.Rotate(0, 0, rotSpeed);
        if (Input.GetMouseButtonDown(1))
        {
          this.rotSpeed *= 0.987f;
        }
        transform.Rotate(0, 0, rotSpeed);
    }
}
