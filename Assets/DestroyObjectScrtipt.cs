using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectScrtipt : MonoBehaviour
{
    public GameObject objectToDestroy;

    bool destroyed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("here");
        if (!destroyed)
        {
            Destroy(objectToDestroy);
            destroyed = true;
        }
    }
}
