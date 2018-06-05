using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathJunk : MonoBehaviour {

	public static float map(float value, float OldMin, float OldMax, float NewMin, float NewMax)
    {

        float OldRange = (OldMax - OldMin);
        float NewRange = (NewMax - NewMin);
        float NewValue = (((value - OldMin) * NewRange) / OldRange) + NewMin;

        return (NewValue);
    }
}
