using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pageActive : MonoBehaviour
{
    public GameObject pageA;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pageActive_()
    {
        Debug.Log("Active is_OK");
        pageA.SetActive(true);
    }
}
    