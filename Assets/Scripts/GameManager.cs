﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float restartDelay = 0f;

    public GameObject completeLevelUI;

    public void CompleteLevel() {
        completeLevelUI.SetActive(true);
    }

    public void EndGame() {
        if (gameHasEnded == false) {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
            Restart();
        }
    }

    void Restart() {
        SceneManager.LoadScene("Level01");
    }

}