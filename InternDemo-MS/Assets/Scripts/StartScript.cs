using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScript : MonoBehaviour
{
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;

    public Text Score;
    public static int scoreValue;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Text1.SetActive(false);
            Text2.SetActive(false);
            Text3.SetActive(false);
            Time.timeScale = 1f;
        }

        Score.text = "Score " + scoreValue;
    }
}
