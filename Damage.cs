using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

    private dead dd;

    void Start()
    {
        dd = GameObject.FindGameObjectWithTag("Player").GetComponent<dead>();

    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            dd.Die();
        }
    }
}
