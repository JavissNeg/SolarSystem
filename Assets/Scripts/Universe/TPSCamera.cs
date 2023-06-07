using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPSCamera : MonoBehaviour
{
    [Header("Camara:")]
    public Vector2 sensibility; //1.5
    //[SerializeField]
    //private Camera cam;

    [Header("Player:")]
    public GameObject player;
    public float speedMove = 260;
    //public GameObject reference; //I needed it for adjust the camera, but camera moves with the character

    private float angleAddHor;
    private float angleAddVer;
    private float mouseHor;
    private float mouseVer;
    private float moveHor;
    private float moveFwd;
    private float moveUp;
    public bool isLock;
    private bool isDescend;
    private Rigidbody rb;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        isLock = true;
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
         moveCam();
    }

    void Update()
    {
        BlockMouse();

        if (!isLock)
        {
            rotateCam();
            proveLeftShift();
        }
    }

    void BlockMouse()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            isLock = !isLock;
        }

        if (isLock == true)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

    }

    void rotateCam()
    {
        mouseHor = Input.GetAxis("Mouse X");
        mouseVer = Input.GetAxis("Mouse Y");
        angleAddHor += mouseHor * sensibility.x;
        //transform.Rotate(Vector3.up * hor * sensibility.x); //Is the same

        angleAddVer -= mouseVer * sensibility.y;
        angleAddVer = Mathf.Clamp(angleAddVer, -50, 80);
        //transform.eulerAngles = Vector3.left * angleAddVer; //Is the same

        transform.eulerAngles = new Vector3(angleAddVer, angleAddHor, 0);

    }

    void moveCam()
    {
        moveHor = Input.GetAxis("Horizontal");
        moveFwd = Input.GetAxis("Vertical");

        if (rb.velocity.magnitude > (speedMove * 2))
        {
            rb.velocity = rb.velocity.normalized * (speedMove * 2);
        }

        if (isDescend == true)
        {
            moveUp = -1;
        }
        else
        {
            moveUp = Input.GetAxis("Jump");
        }

        if (moveHor != 0 || moveUp != 0 || moveFwd != 0)
        {
            rb.AddForce(transform.right * speedMove * moveHor);
            rb.AddForce(transform.up * speedMove * moveUp);
            rb.AddForce(transform.forward * speedMove * moveFwd);
        }
        else
        {
            rb.velocity = Vector3.zero;
        }

        //Debug.Log("Holaa");
    }

    void proveLeftShift()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isDescend = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            isDescend = false;
        }
    }

}