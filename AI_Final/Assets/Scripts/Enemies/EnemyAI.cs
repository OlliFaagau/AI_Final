using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public float speed;
    public Transform[] moveSpots;
    public Transform player;
    
    int currentWP = 0;
    float accuracy = 0.2f;
    
    public bool inRange = false;
    public float detectRange;

    void Awake()
    {
        detectRange *= detectRange;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        float distsqr = (player.position - transform.position).sqrMagnitude;

        if (distsqr < detectRange)
        {
            inRange = true;
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        else if(distsqr >= detectRange)
        {
            inRange = false;
            FollowPath();
        }
    }

    void FollowPath()
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
