using UnityEngine;

public class BattleStateMachine : MonoBehaviour
{
    private IBattleState currentState;

    public PlayerTurnState playerTurnState;
    public EnemyTurnState enemyTurnState;

    private void Start()
    {
        playerTurnState = new PlayerTurnState();
        enemyTurnState = new EnemyTurnState();

        ChangeState(playerTurnState);
    }

    private void Update()
    {
        currentState?.Update();
    }

    public void ChangeState(IBattleState newState)
    {
        currentState?.Exit();
        currentState = newState;
        currentState.Enter();
    }

    public void EndPlayerTurn()
    {
        ChangeState(enemyTurnState);
    }

    public void EndEnemyTurn()
    {
        ChangeState(playerTurnState);
    }
}
