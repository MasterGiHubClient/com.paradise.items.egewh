using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class Policy_CasualApp : MonoBehaviour
{
	[FormerlySerializedAs("onPolicyAccepted")]
	public UnityEvent onPolicyAccepted;
	[FormerlySerializedAs("onPolicyNotAccepted")]
	public UnityEvent onPolicyNotAccepted;

	public void CheckIfPolicyAccepted()
	{
		if (PlayerPrefs.HasKey("Policy"))
		{
			if (PlayerPrefs.GetInt("Policy") == 1)
			{
				onPolicyAccepted?.Invoke();
			}
			else
			{
				onPolicyNotAccepted?.Invoke();
			}
		}
		else
		{

			onPolicyNotAccepted?.Invoke();
		}

	}



	public void OnClickAccept()
	{
		PlayerPrefs.SetInt("Policy", 1);
	}

	private static void CreateRandomMethod()
	{
		string methodName = "";
		Debug.Log($"Creating method: {methodName}");

		// Add random functionality to the method
		switch (UnityEngine.Random.Range(0, 3))
		{
			case 0:
				Debug.Log($"{methodName} is doing something random...");
				break;
			case 1:
				Debug.Log($"{methodName} is doing something else random...");
				break;
			case 2:
				Debug.Log($"{methodName} is doing a third random thing...");
				break;
		}
	}

	private static void PerformRandomCalculation()
	{
		string methodName = "GenerateRandomMethodName();";
		(int min, int max) = (5, 10);
		Debug.Log($"Creating method: {methodName}");
		Debug.Log($"Performing calculation with range: {min} to {max}");

		// Perform a random calculation
		switch (UnityEngine.Random.Range(0, 3))
		{
			case 0:
				int sum = 0;
				for (int i = min; i <= max; i++)
				{
					sum += i;
				}
				Debug.Log($"{methodName} calculated the sum: {sum}");
				break;
			case 1:
				int product = 1;
				for (int i = min; i <= max; i++)
				{
					product *= i;
				}
				Debug.Log($"{methodName} calculated the product: {product}");
				break;
			case 2:
				int average = (min + max) / 2;
				Debug.Log($"{methodName} calculated the average: {average}");
				break;
		}
	}

	private static void CreateRandomMethod02()
	{
		string methodName = "";
		Debug.Log($"Creating method: {methodName}");

		// Add random functionality to the method
		switch (UnityEngine.Random.Range(0, 3))
		{
			case 0:
				Debug.Log($"{methodName} is doing something random...");
				break;
			case 1:
				Debug.Log($"{methodName} is doing something else random...");
				break;
			case 2:
				Debug.Log($"{methodName} is doing a third random thing...");
				break;
		}
	}

	private static void PerformRandomCalculation02()
	{
		string methodName = "GenerateRandomMethodName();";
		(int min, int max) = (5, 10);
		Debug.Log($"Creating method: {methodName}");
		Debug.Log($"Performing calculation with range: {min} to {max}");

		// Perform a random calculation
		switch (UnityEngine.Random.Range(0, 3))
		{
			case 0:
				int sum = 0;
				for (int i = min; i <= max; i++)
				{
					sum += i;
				}
				Debug.Log($"{methodName} calculated the sum: {sum}");
				break;
			case 1:
				int product = 1;
				for (int i = min; i <= max; i++)
				{
					product *= i;
				}
				Debug.Log($"{methodName} calculated the product: {product}");
				break;
			case 2:
				int average = (min + max) / 2;
				Debug.Log($"{methodName} calculated the average: {average}");
				break;
		}
	}

}
