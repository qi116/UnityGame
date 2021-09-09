using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setup : MonoBehaviour
{
    public GameObject statsPrefab;
    void Start()
    {
        Debug.Log("called");
        if (GameObject.FindGameObjectWithTag("Stats") == null)
        {
            Instantiate(statsPrefab, gameObject.transform.position, gameObject.transform.rotation);
        }

    }

    // Update is called once per frame
    
}
