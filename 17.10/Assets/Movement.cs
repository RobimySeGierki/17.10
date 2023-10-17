using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private int kierunekRuchu = 1;
    public float predkoscRuchu = 6;

    void Update()
    {
        transform.position += new Vector3(1, 0,0 ) * Time.deltaTime * kierunekRuchu * predkoscRuchu;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Sciana") 
        {
            kierunekRuchu *= -1;
            collision.gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
        }
    }
}
