using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTurn : TurnGameState
{
    [SerializeField] Text _playerTurnTextUI = null;
    //[SerializeField] Collider _playerPiece;
    //[SerializeField] Collider _AIPiece;
    int _playerTurnCount = 0;

    public override void Enter()
    {
        Debug.Log("Player Turn: Enter");
        _playerTurnTextUI.gameObject.SetActive(true);

        _playerTurnCount++;
        _playerTurnTextUI.text = "PlayerTurn: " + _playerTurnCount.ToString();

        StateMachine.Input.PressedAttack += OnPressedAttack;

        // hook into events
        StateMachine.Input.PressedConfirm += OnPressedConfirm;
    }

    public override void Exit()
    {
        _playerTurnTextUI.gameObject.SetActive(false);
        Debug.Log("Player Turn: Exit");
        // unhook from events
        StateMachine.Input.PressedConfirm -= OnPressedConfirm;
        StateMachine.Input.PressedConfirm -= OnPressedAttack;

        Debug.Log("Player Turn; Exit");
    }

    void OnPressedConfirm()
    {
        Debug.Log("Attempt to enter Enemy State!");
        // change the enemy turn state
        StateMachine.ChangeState<AITurn>();
    }

    void OnPressedAttack()
    {
        Debug.Log("Player attacks the AI!");
        StateMachine.ChangeState<AITurn>();
    }
}
