using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turningWheleer : MonoBehaviour
{
    private float horizontal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        this.gameObject.transform.localRotation = Quaternion.Euler(0, horizontal * 40, 0);
    }
}
