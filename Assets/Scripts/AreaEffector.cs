using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEffector : MonoBehaviour {
    public float time;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
		if (time > 10){
            gameObject.SetActive(false);

        }
        else
        {
            gameObject.SetActive(true);
        }
	}
}
