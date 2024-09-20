using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFlowTrigger : MonoBehaviour
{
    public GameObject waterflow;

    void Start()
    {
        waterflow.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            waterflow.SetActive(true);
        }
    }
}
