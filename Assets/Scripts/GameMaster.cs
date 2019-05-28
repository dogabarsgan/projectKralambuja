using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
//using UnityStandardAssets.ImageEffects;

public class GameMaster : MonoBehaviour {

	public static GameMaster gm;

	void Awake () {
		if (gm == null) {
			gm = GameObject.FindGameObjectWithTag ("GM").GetComponent<GameMaster>();
		}
	}

	public Transform playerPrefab;
	public Transform spawnPoint;
	public float spawnDelay = 2;
	public Transform spawnPrefab;

	void Start()
	{
		
	}

	public IEnumerator _RespawnPlayer () {
		yield return new WaitForSeconds (spawnDelay);

		Instantiate (playerPrefab, spawnPoint.position, spawnPoint.rotation);
		Transform clone = Instantiate (spawnPrefab, spawnPoint.position, spawnPoint.rotation);
		Destroy (clone.gameObject, 3f);
	}

	public static void KillPlayer (Player player) {
		Destroy (player.gameObject);
		gm.StartCoroutine(gm.WaitAndDie());
		//gm.StartCoroutine(gm._RespawnPlayer());
	}

	public static void KillEnemy (Enemy enemy) {
		gm._KillEnemy(enemy);
	}
	public void _KillEnemy(Enemy _enemy) {
		Transform _clone = Instantiate(_enemy.deathParticles, _enemy.transform.position, Quaternion.identity);
		Destroy(_clone.gameObject, 5f);
		Destroy(_enemy.gameObject);
		StartCoroutine(this.WaitAndDie());
	}

	IEnumerator WaitAndDie(){
		yield return new WaitForSeconds(0.5f);
		// resetting stuff
			  HealthBarScript.health = 100f;
				BoatScript.lastPosition.x = 21.655f;
				BoatScript.lastPosition.y =-122.8813f;
				HUD.hasCompletedPuzzle = false;
				CharacterMovement.showCoin = false;
		SceneManager.LoadScene(0);
	}
}
