using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Fields
    public GameObject player;
    public GameObject target;

    bool _activateCombat;

    #endregion

    #region Properties
    #endregion

    #region Methods
    private void Start()
    {
        _activateCombat = false;
    }

    // Update is called once per frame
    void Update()
    {
        CheckForCombat();
    }

    private void CheckForCombat()
    {
        if (Vector3.Distance(player.transform.position, target.transform.position) < 10)
        {
            _activateCombat = true;
        }
    }
    #endregion
}
