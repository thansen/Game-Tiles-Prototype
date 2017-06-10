using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTrigger : MonoBehaviour {
	public string triggerString;
	public Text textUI;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col) {
    if (col.name == "Player") {
    		
    		textUI.Text(triggerString);
    	}   
    }

}
