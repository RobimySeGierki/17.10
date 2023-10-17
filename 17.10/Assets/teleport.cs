using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject cel;
    private void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.tag == "Player")
        {
            other.transform.position = cel.transform.position;
        }

    }

}
