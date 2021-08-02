using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameCon : MonoBehaviour
{
    InputField inputField;
	Text text;

    // Start is called before the first frame update
    void Start()
    {
        inputField = GameObject.Find ("InputField").GetComponent<InputField> ();
		text = GameObject.Find ("Message").GetComponent<Text> ();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InputText(){
 
		text.text = inputField.text;
 
	}
}
