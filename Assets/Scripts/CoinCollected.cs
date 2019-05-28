using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinCollected : MonoBehaviour {
	
      SpriteRenderer rend;

      void OnTriggerEnter2D(UnityEngine.Collider2D c) {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;

            string caseSwitch = c.gameObject.tag;
            FindObjectOfType<AudioManager>().Play("Coin");
            SceneManager.LoadScene("MainScene");

      }
  

}
