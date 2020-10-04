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

    [SerializeField]
    private Transform tr;

    public float moveSpeed = 80.0f;
    public float rotSpeed = 80.0f;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        r = Input.GetAxis("Mouse X");

        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);

        tr.Translate(moveDir.normalized * moveSpeed * Time.deltaTime, Space.Self);

        tr.Rotate(Vector3.up * rotSpeed * Time.deltaTime * r);

        AnimationUpdate();
    }

    void AnimationUpdate()
    {
        if (h == 0 && v == 0)
            animator.SetBool("isRunning", false);
        else
        {
            animator.SetBool("isRunning", true);
        }
    }
}
