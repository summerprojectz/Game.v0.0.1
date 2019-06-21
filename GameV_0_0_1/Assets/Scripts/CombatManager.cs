using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    #region Fields
    public enum CombatStates
    {
        Selection,
        Move
    }

    CombatStates _currentState;

    private Camera _battleCam;
    private Camera _thirdPersonCam;
    #endregion

    #region Properties
    #endregion

    #region Methods
    private void Start()
    {
        _currentState = CombatStates.Selection;
        _battleCam = GameObject.FindGameObjectWithTag("BattleCamera").GetComponent<Camera>();
        _thirdPersonCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        _thirdPersonCam.enabled = false;
        _battleCam.enabled = true;
    }

    private void Update()
    {
        switch (_currentState)
        {
            case CombatStates.Selection:
                break;
            case CombatStates.Move:
                break;
        }
    }
    #endregion
}
