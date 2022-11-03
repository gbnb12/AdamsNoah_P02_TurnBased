using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setup : TurnGameState
{
    bool _activated = false;

    public Piece[,] pieces = new Piece[8, 8];
    public GameObject PlayerPiecePrefab;
    public GameObject AIPiecePrefab;

    public override void Enter()
    {
        Debug.Log("Setup: Enter");
        GenerateBoard();
        // Cant change state while still in Enter()/Exit() transition!
        // Dont put ChangeState<> here.
        _activated = false;
    }

    public override void Tick()
    {
        if(_activated == false)
        {
            _activated = true;
            StateMachine.ChangeState<PlayerTurn>();
        }
    }

    public override void Exit()
    {
        _activated = false;
        Debug.Log("Setup: Exit");
    }

    public void GenerateBoard()
    {
        // Generate Player team
        for (int y = 0; y < 3; y++)
        {
            for (int x = 0; x < 8; x += 2)
            {
                // Generate pieces
                GeneratePiece(x, y);
            }
        }
    }

    private void GeneratePiece(int x, int y)
    {
        GameObject go = Instantiate(PlayerPiecePrefab) as GameObject;
        go.transform.SetParent(transform);
        Piece p = go.GetComponent<Piece>();
        pieces[x, y] = p;
    }
}
