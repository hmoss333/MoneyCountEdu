﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedeemExit : MonoBehaviour {

	
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void QuitApp()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
