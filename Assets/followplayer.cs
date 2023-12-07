using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class followplayer : MonoBehaviour
{
    private GameObject player;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the player and agent are valid
        if (player != null && agent != null)
        {
            // Set the destination to the player's current position
            agent.SetDestination(player.transform.position);
        }
    }
}
