using UnityEngine;
using System.Collections;

public class playermovement : MonoBehaviour
 
{
    //public static float Clamp(float value, float -45f, float 45f);
    public float rotationLimitLeft;
    public float rotationLimitRight;
    public float rotationspeed;
    public float speed;
    public float rotZ;
    void Awake() {
        speed = speed * -1;
        
    }
    
    void Update()
    {
        transform.position -= new Vector3(0.0f, speed * Time.deltaTime , 0.0f);
        rotZ = transform.rotation.z;
        Debug.Log(rotZ + " rotz");
        if (Input.GetKey("a")) {
            Debug.Log("getKeyDownleft");
            rotateLeft();
        }
        if (Input.GetKey("d"))
        {
            Debug.Log("getKeyDownright");
            rotateright();
        }
    }
    void rotateLeft()
    {
        if (rotZ > rotationLimitLeft)
        {
            rotZ = rotationLimitLeft;
        }
        else
        {

            transform.Rotate(Vector3.forward, rotationspeed);
        }
    }
    void rotateright()
    {
        if (rotZ < rotationLimitRight)
        {
            rotZ = Mathf.Clamp(rotZ, -45, 45);
        }
        else
        {
            transform.Rotate(Vector3.back, rotationspeed);
        }
    }
}