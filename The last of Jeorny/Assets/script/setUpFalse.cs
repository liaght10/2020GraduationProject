using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setUpFalse : MonoBehaviour
{

    public GameObject setUpFalse_;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start is_OK");
        setUpFalse_.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SUFalse()
    {
        Debug.Log("FalseUpdate is_OK");
        setUpFalse_.SetActive(false);
    }
}
