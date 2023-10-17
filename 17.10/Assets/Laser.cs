using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Laser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown((int)MouseButton.Left))
        {
            Debug.Log("Uzyto klawisza E");
            RaycastHit hit;
            if(Physics.Raycast(transform.position, transform.forward, out hit, 5))
            {
                hit.collider.gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
            }
        }
    }
}
