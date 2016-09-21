using UnityEngine;
using System.Collections;

public class FollowTarget : MonoBehaviour
{

    public Transform target;

    private Vector3 offset;

    void Start()
    {
        offset = target.position - transform.position;
    }
    void Update ()
    {
        transform.position = target.position - offset;
	}
}
