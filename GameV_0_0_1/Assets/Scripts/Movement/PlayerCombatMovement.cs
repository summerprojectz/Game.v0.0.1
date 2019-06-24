using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerCombatMovement : MonoBehaviour
{
    #region Fields
    NavMeshAgent _agent;
    Camera _battleCam;
    
    #endregion

    #region Properties 
    #endregion

    #region Methods
    private void Start()
    {
        _agent = GameObject.FindGameObjectWithTag("Player").GetComponent<NavMeshAgent>();
        _battleCam = GameObject.FindGameObjectWithTag("BattleCamera").GetComponent<Camera>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = _battleCam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                _agent.SetDestination(hit.point);
            }
        }
    }
    #endregion
}
