using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal_Script : MonoBehaviour
{
    public GameObject winText;

    // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Debug.Log("YOU ARE WIN");

            winText.SetActive(true);

            Time.timeScale = 0f;
        }

    }
}
