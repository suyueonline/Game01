using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurnState : IBattleState
{
    public void Enter(){
        Debug.Log("=== 敌人回合开始 ===");
    }

    public void Update(){

    }

    public void Exit(){
        Debug.Log("=== 敌人回合结束 ===");
    }
}