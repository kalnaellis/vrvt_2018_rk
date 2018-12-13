using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AIscript : MonoBehaviour
{
    [SerializeField] private float maxdistance = 10;
    private NavMeshAgent navmeshAgent;

    public GameObject target;

    // Use this for initialization
    void Start()
    {

        navmeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        followtarget();
    }
    void followtarget()
    {
        float distance = Vector3.Distance(target.transform.position, transform.position);
        if (distance < maxdistance)
        {
            navmeshAgent.destination = target.transform.position;
        }
    }

}