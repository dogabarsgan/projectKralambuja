using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// will sit on an object
public class DialogTrigger: MonoBehaviour {

	public Dialog dialog;

	public void TriggerDialog(){

		FindObjectOfType<DialogManager>().StartDialog(dialog);


	}

}
