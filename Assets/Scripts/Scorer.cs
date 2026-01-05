using System;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private float Score { get; set; } = 0;

    private void OnCollisionEnter(Collision other)
    {
        Score++;
        Debug.Log("You've bumped into a thing this many times: " + Score);
    }
}
