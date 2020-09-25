using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogCutting : MonoBehaviour
{
    public GameObject CutVersion;
    public GameObject cuteffect;
    CameraShake cameraShake;

    private void Start()
    {
        cameraShake = CameraShake.FindObjectOfType<CameraShake>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(CutVersion, transform.position, transform.rotation);
            StartScript.scoreValue += 1;
            GameObject effect = Instantiate(cuteffect, transform.position, Quaternion.identity);
            Destroy(effect, 1f);
            Destroy(gameObject);

            StartCoroutine(cameraShake.Shake(.3f, .1f));
        }
    }
}
