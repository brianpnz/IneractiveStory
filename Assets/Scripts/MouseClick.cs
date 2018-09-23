using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        Debug.Log("Mouse was cliked on " + this.name);

        BasicInkExample story = GetComponent<BasicInkExample>();

        story.StartStory();
    }
}
