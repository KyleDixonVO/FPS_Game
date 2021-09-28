using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float turnSpeed = 4.0f;
    public float minTurnAngle = -90.0f;
    public float maxTurnAngle = 90.0f;
    private float rotX;
    public GameObject Player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Player.transform.position;
    }
    
    void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
    }
    private void Update()
    {
        MouseAiming();
    }
    void MouseAiming()
    {
        float y = Input.GetAxis("Mouse X") * turnSpeed;
        rotX += Input.GetAxis("Mouse Y") * turnSpeed;

        rotX = Mathf.Clamp(rotX, minTurnAngle, maxTurnAngle);

        transform.eulerAngles = new Vector3(-rotX, transform.eulerAngles.y + y, 0);

    }
}
