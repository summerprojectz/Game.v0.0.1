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

    public Camera CombatCam;
    #endregion

    #region Properties
    #endregion

    #region Methods
    private void Start()
    {
        _currentState = CombatStates.Selection;
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
