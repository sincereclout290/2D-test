using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 
public class Basicslime : MonoBehaviour
{
    NavMeshAgent agent; 
    GameObject player; 
    public float attackDistance = 15f;

    // Start is called before the first frame update 
    void Start() 
    { 
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false; 
        agent.updateUpAxis = false; 
        
        player = GameObject.FindWithTag("Player");
    } 

    // Update is called once per frame 
    void Update() 
    { 
        float distance = Vector2.Distance(transform.position, player.transform.position);
        if(distance < attackDistance)
        {
            agent.SetDestination(player.transform.position); 
        }
    } 
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow ;
        Gizmos.DrawWireSphere(transform.position, attackDistance);
    }

}
