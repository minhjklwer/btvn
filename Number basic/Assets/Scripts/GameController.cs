using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public Text DisplayText;
	public Button ButtonYes;
	public Button ButtonHigher;
	public Button ButtonLower;
	public Button playagainButton;

	int ComGuess;
	int GuessNumber;
	string Choose;
	s

	// Use this for initialization
	void Start () {Playagain();}

	public void  Playagain (){
		ComGuess = Random.Range (0 , 100);

		GuessNumber = ComGuess;

		DisplayText.text = "Think of a number from 0 to 100 but don't tell me. Now, is your number " + GuessNumber;

		playagainButton.gameObject.SetActive (false);

		ButtonYes.gameObject.SetActive (true);

		ButtonLower.gameObject.SetActive (true);

		ButtonHigher.gameObject.SetActive (true);

		CompareGuess ();
		}

	public void buttonYes()
	{
		Choose = "Yes";
		CompareGuess();
	}

	public void buttonHigher()
	{
		Choose  = "Higher";
		CompareGuess();
	}

	public void buttonLower()
	{
		Choose  = "Lower";
		CompareGuess();
	}


	public void CompareGuess(){

		if (Choose == "Higher") 
		{
			ComGuess = Random.Range (GuessNumber, 100);
			GuessNumber = ComGuess;
			DisplayText.text = "Is your number " + GuessNumber;
		}
		if (Choose == "Lower") 
		{
			ComGuess = Random.Range (0 , GuessNumber);	
			GuessNumber = ComGuess;
			DisplayText.text = "Is your number " + GuessNumber;
		}
		if (Choose == "Yes") 
		{
			DisplayText.text = "Yay, I won, stupid player ";

			playagainButton.gameObject.SetActive (true);

			ButtonYes.gameObject.SetActive (false);

			ButtonLower.gameObject.SetActive (false);

			ButtonHigher.gameObject.SetActive (false);

		}
	}
}





//	public void GetInput (){
//		guess = inputField.text;
//		guessCount++;
//		CompareGuess ();
//		inputField.text = "";
//		inputField.ActivateInputField();
//	}
//
//
//	public void CompareGuess(){
//		guessInt = int.Parse (guess);
//		if (guessInt > numberToGuess) {
//			displayText.text = "Your guess is higher than our number";
//		}else if (guessInt < numberToGuess){
//			displayText.text =" Your guess is lower than our number";
//		}else{
//			playagainButton.gameObject.SetActive (true);
//			displayText.text =  "You win. It takes you "+ guessCount + " times to guess";
//		}
//	}
//
//	public void PlayAgain (){
//		numberToGuess = Random.Range (0, 100);
//
//		displayText.text = "Guess a number between 0 - 100";
//
//		playagainButton.gameObject.SetActive (false);
//
//		guessCount = 0;
//	}


		
		

