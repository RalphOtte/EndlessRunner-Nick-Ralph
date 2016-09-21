using UnityEngine;
using System.Collections;

public class BackgroundMover : MonoBehaviour {

    public float speed;

	void Update ()
    {
        //(Speed * -1) inverts value, this makes it so we dont have to input negative speeds to go down
        transform.position += new Vector3(0.0f, (speed * -1)* Time.deltaTime, 0.0f);
    }
}
