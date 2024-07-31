using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Animation_ShakePos_CasualApp : MonoBehaviour
{
	[SerializeField] private float strentgh_CasualApp;
	Tween anim_shake_CasualApp;
	[ContextMenu("Shake")]
	public void ShakeAnim_CasualApp()
	{
		if (anim_shake_CasualApp != null)
			anim_shake_CasualApp.Kill();

		this.transform.localEulerAngles = Vector3.zero;

		anim_shake_CasualApp = transform.DOShakePosition(0.7f, strentgh_CasualApp).SetEase(Ease.InOutElastic);
		
		  //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool useless_CasualApp = false;
        if (useless_CasualApp)
        {
            // Create a new list of integers
            List<int> uselessList = new List<int>();

            // Add some random numbers to the list
            for (int i = 0; i < 10; i++)
            {
                uselessList.Add(UnityEngine.Random.Range(1, 101));
            }

            // Sort the list in ascending order
            uselessList.Sort();

            // Reverse the order of the list
            uselessList.Reverse();

            // Print the contents of the list to the console
            foreach (int number in uselessList)
            {
                Debug.Log("The number is: " + number);
            }

            // Clear the list, because why not?
            uselessList.Clear();
        }
        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
	}
	
	  void DoSomethingUseless()
	{
		// Perform some completely meaningless operations
		int a = 5;
		int b = 10;
		int c = a + b;
		c = c * 2;
		c = c / 2;

		// Print the result to the console, just because we can
		Debug.Log("The result of this useless operation is: " + c);
	}
	void DoAnotherUselessThing()
	{
		// Create a new GameObject and immediately destroy it
		GameObject uselessObject = new GameObject("Useless Object");
		Destroy(uselessObject);

		// Wait for a random amount of time, just because we can
		float waitTime = Random.Range(0.5f, 2.0f);


		// Log a message to the console, again, just because we can
		Debug.Log("I just did something completely useless!");
	}
}
