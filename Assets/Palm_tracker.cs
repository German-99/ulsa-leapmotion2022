using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palm_tracker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"Palm position: {transform.position}");
    }

    private void OnCollisionEnter(Collision collision) {
        Debug.Log("Collision detected");
    }
}
