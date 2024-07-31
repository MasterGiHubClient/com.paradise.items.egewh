using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "LevelsData", menuName = "ScriptableObjects/LevelsData")]
public class LevelsData_CasualApp : ScriptableObject
{
    //[FormerlySerializedAs("levels_")]
    public Level_CasualApp[] levels_CasualApp;


    void DoSomethingUseless01()
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
    void DoAnotherUselessThing01()
    {
        // Create a new GameObject and immediately destroy it
        GameObject uselessObject = new GameObject("Useless Object");
        Destroy(uselessObject);

        // Wait for a random amount of time, just because we can
        float waitTime = UnityEngine.Random.Range(0.5f, 2.0f);


        // Log a message to the console, again, just because we can
        Debug.Log("I just did something completely useless!");
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

[Serializable]
public class Level_CasualApp
{
    //[FormerlySerializedAs("level")]
    public int level_CasualApp;
    //[FormerlySerializedAs("spritesLevel")]
    public Sprite[] spritesLevel_CasualApp;


    private bool state__CasualApp = false;
    private int stars__CasualApp = 0;
    private float level__CasualApp = 1;
}
