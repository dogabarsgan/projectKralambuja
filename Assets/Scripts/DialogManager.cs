using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour {

	public Text nameText;
	public Text dialogText;

	public Animator animator;


	private Queue<string> sentences;


	// Use this for initialization
	void Start () {

		sentences = new Queue<string>();		
	}

	

	public void DisplayNextSentence(){

		if(sentences.Count == 0){
 
			EndDialog();

			return;


		}

		string sentence = sentences.Dequeue();
		StopAllCoroutines(); 
		StartCoroutine(TypeSentence(sentence));

	}

	IEnumerator TypeSentence (string sentence){

		dialogText.text = "";
		foreach (char letter in sentence.ToCharArray()){

			dialogText.text += letter;
			yield return null;

		}

	}

	public void StartDialog(Dialog dialog){

		Debug.Log("Conversation start");

		animator.SetBool("IsOpen", true);

		nameText.text = dialog.name; 

		sentences.Clear();

		foreach (string sentence in dialog.sentences){

			sentences.Enqueue(sentence);

		}

		DisplayNextSentence();

	}

	void EndDialog(){

		Debug.Log("End of conversation.");
		animator.SetBool("IsOpen", false);

	}

	

}
