using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Fields
    public GameObject player;
    public GameObject target;

    [SerializeField]
    private GameObject _combatManger;

    bool _activateCombat;

    #endregion

    #region Properties
    public bool ActivateCombat
    {
        get { return _activateCombat; }
    }
    #endregion

    #region Methods
    private void Start()
    {
        _activateCombat = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(_activateCombat == false)
        {
            CheckForCombat();
        }

        Debug.Log(_activateCombat);
    }

    private void CheckForCombat()
    {
        if (Vector3.Distance(player.transform.position, target.transform.position) < 10)
        {
            _activateCombat = true;
            Instantiate(_combatManger);
        }
    }
    #endregion
}
