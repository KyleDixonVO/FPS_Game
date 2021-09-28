using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    public GameObject mainCam;
    public Rigidbody rb;
    private bool jump;
    private bool moveLeft;
    private bool moveRight;
    private bool moveForward;
    private bool moveBackward;
    private bool grounded;
    


    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    private void Update()
    {
        Jump();
        Movement();
        player.transform.rotation = mainCam.transform.rotation;



    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }
    }



    void FixedUpdate()
    {
        if (jump == true)
        { rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
            jump = false;
        }

        

    }


    void Movement()
    {
        Vector3 dir = new Vector3(0, 0, 0);

        dir.x = Input.GetAxis("Horizontal");
        dir.z = Input.GetAxis("Vertical");

        rb.transform.Translate(dir * 10 * Time.deltaTime);
    }
}
