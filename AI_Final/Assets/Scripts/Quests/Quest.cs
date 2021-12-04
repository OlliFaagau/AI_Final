using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Quest
{
    public bool isActive;
    public bool isComplete;
    public Sprite beastie;
    public string beastieName;
    public string response1, response2, response3, response4;
    public Sprite itemReward;
}
