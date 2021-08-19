using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFPP : MonoBehaviour
{
    private float horiz;
    private float vert;
    private Rigidbody playerRb;
    private float rotX;
    private float rotY;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horiz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
        playerRb.AddForce(transform.right * horiz* Time.deltaTime, ForceMode.VelocityChange);
        playerRb.AddForce(transform.forward * vert * Time.deltaTime * 10, ForceMode.Impulse);
       
    }

    public void House1Street1()
    {
        transform.position = new Vector3(-80, -20, 105);
    }

    public void House2Street1()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    public void House3Street1()
    {
        transform.position = new Vector3(355, -36, 33);
    }

    public void House1Street2()
    {
        transform.position = new Vector3(-80, -20, 105);
    }

    public void House2Street2()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    public void House3Street2()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    public void House1Street3()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    public void House2Street3()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    public void House3Street3()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    
}

    
