using UnityEngine;
using UnityEngine.UI;

public class Info : MonoBehaviour {

	public Transform player;
	public Text scoreText;
	
	// Update is called once per frame
	void Update () {
		scoreText.text="\"F\" for left! \"J\" for right! \"Esc\" for exit!";
	}
}
