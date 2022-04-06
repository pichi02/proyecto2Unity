using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] [Range(1, 2)] private int player;
    private Rigidbody rb;
    private float hor;
    private float ver;


    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        if (player == 0)
        {
            hor = Input.GetAxisRaw("Horizontal");
            ver = Input.GetAxisRaw("Vertical");
        }
        else if (player == 1)
        {
            hor = Input.GetAxisRaw("Horizontal2");
            ver = Input.GetAxisRaw("Vertical2");
        }


        if (hor != 0 || ver != 0)
        {
            Vector3 dir = transform.forward * ver + transform.right * hor;
            rb.MovePosition(transform.position + dir * speed * Time.deltaTime);
        }
    }
}