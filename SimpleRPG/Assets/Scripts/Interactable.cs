using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Interactable : MonoBehaviour {

    [HideInInspector] public NavMeshAgent playerAgent;
    private bool hasInteracted;

    public virtual void MoveToInteraction(NavMeshAgent playerAgent)
    {
        hasInteracted = false;
        this.playerAgent = playerAgent;
        playerAgent.stoppingDistance = 2.5f;
        playerAgent.destination = this.transform.position;
    }

    private void Update()
    {
        if (playerAgent != null && !playerAgent.pathPending && !hasInteracted)
        {
            if (playerAgent.remainingDistance <= playerAgent.stoppingDistance)
            {
                Interact();
                EnsureLookDirection();
                hasInteracted = true;
            }
        }
    }

    void EnsureLookDirection()
    {
        playerAgent.updateRotation = false;
        Vector3 lookDirection = new Vector3(transform.position.x, playerAgent.transform.position.y, transform.position.z);
        playerAgent.transform.LookAt(lookDirection);
        playerAgent.updateRotation = true;
    }

    public virtual void Interact()
    {
        Debug.Log("Interacting with base class.");
    }
}
