using UnityEngine;
using System.Collections;

public class playermovent : MonoBehaviour {
    public float speed;
    public Rigidbody rb;
    private Rigidbody rigidBody;
    private Vector3 movement = new Vector3();

    void Start()
    {
    rb = GetComponent <Rigidbody>();
    }
    void Awake()
    {
        rigidBody  = GetComponent<Rigidbody>  ();
       
    } 
	void Update  ()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        movement = new Vector3(x, 0f, z);

        if (Input.GetButtonDown("Jump")) 
        {
            rb.velocity = new Vector3(0, 8, 0);
        }
	}
	
	
	void FixedUpdate ()
    {
        rigidBody.AddForce (movement.normalized * speed);
	}
}
