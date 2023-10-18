using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private float attackDistance = 0.5f;
    private float attackSpeed = 2f;
    public GameObject Target;
    private Rigidbody rBody;
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        FollowTarget();
    }

    void FollowTarget()
    {
    
        if (Target != null)
        {
            float distanceToTarget = Vector3.Distance(transform.position, Target.transform.position); 

            if (distanceToTarget > attackDistance)
            {
                transform.LookAt(Target.transform); 
                rBody.velocity = transform.forward * attackSpeed;
            }
            else
            {
                rBody.velocity = Vector3.zero; 
            }
        }
        else
        {
   
        }
    }

    void OnCollisionEnter(Collision collision)
    {
      if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
