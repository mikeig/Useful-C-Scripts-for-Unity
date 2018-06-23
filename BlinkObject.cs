using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkObject : MonoBehaviour {
    public GameObject objToBlink;

    private float timer;
	// Use this for initialization
	void Start () {
        timer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            if (objToBlink.activeInHierarchy)
            {
                objToBlink.SetActive(false);
            }
            else
            {
                objToBlink.SetActive(true);
            }
            timer -= 1;
        }
	}
}
