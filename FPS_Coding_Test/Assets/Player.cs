using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    public Rigidbody rb;
    public GameObject mainCam;
    private bool jump;
    private bool grounded;



    // Start is called before the first frame update
    void Start()
    {



    }

    public void FixedUpdate()
    {
        OnJump();
        OnFire();
        OnMove();
    }
    public void OnJump()
    { 
        rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
    }

    public void OnMove()
    { 
    
    }

    public void OnFire()
    { 
    
    }
    // Update is called once per frame
    private void Update()
    {
      
        //player.transform.rotation = mainCam.transform.rotation;


    }

    
   
 
}