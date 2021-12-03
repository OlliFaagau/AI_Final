using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public float speed;
    public Transform[] moveSpots;
    int currentWP = 0;
    int counter = 0;
    float accuracy = 0.2f;

    void Update()
    {
        if (moveSpots.Length == 0) return;
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[currentWP].position, speed * Time.deltaTime);

        if (Vector2.Distance(moveSpots[currentWP].transform.position, transform.position) < accuracy)
        {
            currentWP++;
            if (currentWP >= moveSpots.Length)
            {
                currentWP = 0;
            }
        }

        var direction = moveSpots[currentWP].transform.position - transform.position;
        transform.Translate(0, 0, Time.deltaTime * speed);
    }


}
