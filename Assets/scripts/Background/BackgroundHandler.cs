using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BackgroundHandler : MonoBehaviour {

    public List<GameObject> backgrounds = new List<GameObject>();
    [SerializeField]private Vector3 spawnPos;

	void Start ()
    {
        Instantiate(backgrounds[0], spawnPos ,Quaternion.identity);
	}
	
	void Update ()
    {
	    //Needs player height. Depending on that it activates one of the bgs, which scrolls by itself
	}
}
