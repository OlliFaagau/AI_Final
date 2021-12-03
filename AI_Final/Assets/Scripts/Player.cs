using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int coins;
    public static int burgers;
    public Quest q1, q2, q3, q4, q5, q6;

    public void ResetGame()
    {
        coins = 0;
        burgers = 0;
    }
}
