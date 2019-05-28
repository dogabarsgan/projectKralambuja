using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class TriggerScript : MonoBehaviour {

    public DialogTrigger trigger;

	void OnCollisionEnter2D(UnityEngine.Collision2D collisionInfo) {

		string caseSwitch = collisionInfo.gameObject.tag;
      
        switch (caseSwitch) {
            case "Island1":
                FindObjectOfType<AudioManager>().Play("Popup");
                trigger.TriggerDialog();
                break;
            case "Island2":
                break;
		    case "Island3":
                break;
		    case "Island4":
                if(CharacterMovement.showCoin)
                    SceneManager.LoadScene("FightScene");
                break;
		    case "Island5":
				//puzzle island
                if (!HUD.hasCompletedPuzzle) {
                    SceneManager.LoadScene("PuzzleScene");
                    HUD.hasCompletedPuzzle = true;
                }
                break;
            case "Squid":
			    //puzzle island
                HealthBarScript.health -= 10;
                FindObjectOfType<AudioManager>().Play("NearCreature");		
                break;
            case "Shark":
				//puzzle island
                HealthBarScript.health -= 10;
                FindObjectOfType<AudioManager>().Play("NearCreature");			
                break;  	
            default:
                break;
        }
	}
}
