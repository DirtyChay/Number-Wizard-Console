using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
     int lowerBound;
     int upperBound;
     int guess;
     //int numLies; // counts the number of times the user refused to admit defeat...

     // Start is called before the first frame update
     void Start()
     {
          GameIntro();
     }
     // Moved setup to here
     void GameIntro()
     {
          lowerBound = 1;
          upperBound = 1000;
          guess = 500;
          Debug.Log("Sup, welcome to Number Wizard."); // more flexibility and control over print
          Debug.Log("Think of a number, and I'll try to guess it.");
          Debug.Log("The smallest number I'll accept is: " + lowerBound);
          Debug.Log("The highest number I can count to is: " + upperBound);
          Debug.Log("If I'm right, press Enter. Press BackSpace to restart the game.");
          Debug.Log("Otherwise, you gotta tell me if your number is higher or lower.");
          Debug.Log("Controls: Push Up = Higher, Push Down = Lower, Push Enter = Correct");
          Debug.Log("My first guess is: " + guess);
          upperBound += 1; // let user guess upperBound
     }
     // Update is called once per frame
     void Update()
     {
          //Detect when the up arrow key is pressed down
          if (Input.GetKeyDown(KeyCode.UpArrow))
          {
               Debug.Log("So it's bigger huh? Heh so am I...");
               lowerBound = guess;
               NextGuess();
          }
          //Detect when the down arrow key is pressed down
          else if (Input.GetKeyDown(KeyCode.DownArrow))
          {
               Debug.Log("Guess it's smaller.");
               upperBound = guess;
               NextGuess();
          }
          //Detect when the Return key is pressed down
          else if (Input.GetKeyDown(KeyCode.Return))
          {
               Debug.Log("Hmph child's play.");
               Debug.Log("Press Backspace to play again.");
          }
          // Detect when BackSpace is pressed down
          else if (Input.GetKeyDown(KeyCode.Backspace))
          {
               Debug.Log("Restarting Game!");
               GameIntro();
          }
     }
     void NextGuess()
     {
          guess = (lowerBound + upperBound) / 2;
          Debug.Log("My guess is: " + guess);
     }
}