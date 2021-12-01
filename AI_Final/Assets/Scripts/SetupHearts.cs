using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupHearts : MonoBehaviour
{
    public int total;

    public void SubmitSetup()
    {
        HealthBar.instance.SetupHearts(total);
    }

}
