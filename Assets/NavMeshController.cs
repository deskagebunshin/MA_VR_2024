using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 
[RequireComponent(typeof(NavMeshAgent))]
public class NavMeshController : MonoBehaviour
{
    // Start is called before the first frame update
    NavMeshAgent agent;
    public Transform target;
    public Transform home;
    public Animator animator;
    public float minimumDistance = 10f;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();        
    }

    // Update is called once per frame
    void Update()
    {
       
        animator.SetFloat("Speed", agent.velocity.magnitude);
    }

    public void SetDestination(Vector3 position)
    {
        agent.SetDestination(position);
    }
}
