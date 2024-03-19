using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    NavMeshAgent navMeshAgent;

    void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0)) // Fare tıklamasını algıla
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit)) // Fare tıklamasının dünya koordinatlarını al
            {
                MoveTo(hit.point); // Hedefe git
            }
        }
    }

    void MoveTo(Vector3 destination)
    {
        navMeshAgent.SetDestination(destination); // Hedefe git
    }
    
  
}