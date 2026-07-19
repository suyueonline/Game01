using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurnState : IBattleState
{
    public void Enter(){
        Debug.Log("=== 玩家回合开始 ===");
    }

    public void Update(){

    }

    public void Exit(){
        Debug.Log("=== 玩家回合结束 ===");
    }
}