using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTrigger : MonoBehaviour {
	public string triggerString;
	public float visibilityDuration;
	private Text textUI;
	private GameObject textObject;

	// Use this for initialization
	void Start () {
		textObject = GameObject.Find("TextBox");
		textUI = textObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col) {
    if (col.name == "Player") {
    		
    		textUI.text = triggerString;

    		Animation fadeAnimation = textObject.GetComponent<Animation>();
    		fadeAnimation.Stop();
 			fadeAnimation.Play("simpleFade");
    	}   
    }

}
