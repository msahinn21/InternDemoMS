using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogCutting : MonoBehaviour
{
    public GameObject CutVersion;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(CutVersion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
