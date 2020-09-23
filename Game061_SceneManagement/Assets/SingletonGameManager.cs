using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonGameManager : MonoBehaviour
{
    protected SingletonGameManager(){}
    public string Name{get;} ="SingletonGameManager";
    public int GameScore{get;set;} = 0;
}

