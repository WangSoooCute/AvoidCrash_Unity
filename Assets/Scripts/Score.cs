using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform player;
	public Text scoreText;
	
	// Update is called once per frame
	void Update () {
		float s = player.position.z / 185*100;
		scoreText.text="Score:"+s.ToString("0");
	}
}
