using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    public int targetScore;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Target Hit");
    }
}

