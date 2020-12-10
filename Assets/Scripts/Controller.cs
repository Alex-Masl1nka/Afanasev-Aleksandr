using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject cube;
    public bool ObComp = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) ObComp = !ObComp;
        if (ObComp)
        {
            if (Input.GetKeyDown(KeyCode.Space))
                Destroy(cube);
            if (Input.GetKeyDown(KeyCode.I))
                Instantiate(cube);
            if (Input.GetKeyDown(KeyCode.D))
                cube.SetActive(false);
            if (Input.GetKeyDown(KeyCode.E))
                cube.SetActive(true);
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
                Destroy(cube.GetComponent<MeshRenderer>());
            if (Input.GetKeyDown(KeyCode.I))
                cube.AddComponent<MeshRenderer>();
            if (Input.GetKeyDown(KeyCode.D))
                cube.GetComponent<MeshRenderer>().enabled = false;
            if (Input.GetKeyDown(KeyCode.E))
                cube.GetComponent<MeshRenderer>().enabled = true;
        }
    }
    
}
