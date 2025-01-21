using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 
public class BasicEnermy : MonoBehaviour 
{ 
    NavMeshAgent agent; 
    GameObject player; 
    Animator animator;
    
    float attackDistance = 15f;

    // Start is called before the first frame update 
    void Start() 
    { 
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false; 
        agent.updateUpAxis = false; 
        
        player = GameObject.FindWithTag("Player"); 
    
        animator = GetComponent<Animator>();
    } 

    // Update is called once per frame 
    void Update() 
    { 
        float distance = Vector2.Distance(transform.position, player.transform.position);
        if(distance < attackDistance)
        {
            agent.SetDestination(player.transform.position); 
        }

        animator.SetFloat("input x", agent.velocity.x);
        animator.SetFloat("input y", agent.velocity.y);
    } 
}
