using System;
using System.Collections;
using System.Collections.Generic;
using _SnapCity.GameEvents;
using UnityEngine;

public class TEST_GameInited : MonoBehaviour
{
    [SerializeField] private GameEvent _gameInitEvent;
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(5.5f);
        _gameInitEvent.Raise();
    }
}
