using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private float h = 0.0f;
    private float v = 0.0f;
    private float r = 0.0f;
    private float ry = 0.0f;
    private float rz = 0.0f;
    private float viewRange = 90.0f;

    [SerializeField]
    private Transform tr;

    public float moveSpeed = 80.0f;
    public float rotSpeed = 80.0f;
    public float jumpPower = 2.0f;

    private Rigidbody bbody;
    private Physics physics;
    private BoxCollider BCollider;

    public Slider HSlider;

    static public bool isGround = true;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        BCollider = GetComponent<BoxCollider>();
        bbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        r = Input.GetAxis("Mouse X");

        
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);

        tr.Translate(moveDir.normalized * moveSpeed * Time.deltaTime);
        tr.Rotate(Vector3.up * rotSpeed * Time.deltaTime * r);

        if (isGround == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            { tr.Translate(0, jumpPower, 0, Space.World); }
        }

        else if (seaDamage.isSea != false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // tr.Translate(Vector3.up * jumpPower, Space.World);
                //  tr.Translate(0, jumpPower, 0, Space.World);
                GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);

            }
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround = true;
        }
    }

    private void OnCollisionExit(Collision collision2)
    {
        if (collision2.gameObject.tag == "Ground")
        {
            isGround = false;
        }
    }

}
