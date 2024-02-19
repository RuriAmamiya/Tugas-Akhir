using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ai : MonoBehaviour
{

    // Start is called before the first frame update

    public NavMeshAgent npc;
    public Transform target,target1;

    bool patroling = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(patroling == true)
        {
            npc.SetDestination(target.position);
        }

        if (patroling == false)
        {
            npc.SetDestination(target1.position);
        }

    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "target1")
        {
            patroling = false;
        }
        if (other.gameObject.tag == "target2")
        {
            patroling = true;
        }
    }

}
