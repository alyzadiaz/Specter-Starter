using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState
{
    protected enum STATE{
        PLAY
    }

    protected enum EVENT{
        ENTER, UPDATE, EXIT
    }

    protected STATE name;
    protected EVENT stage;
    protected GameState nextState;
    protected GameManager gameManager;

    protected GameState(){
        gameManager = GameManager.instance();
    }

    protected virtual void Enter(){
        stage = EVENT.UPDATE;
    }

    protected virtual void Update(){
        stage = EVENT.UPDATE;
    }

    protected virtual void Exit(){
        stage = EVENT.EXIT;
    }

    public GameState process(){
        if(stage==EVENT.ENTER) Enter();
        if(stage==EVENT.UPDATE) Update();
        if(stage==EVENT.EXIT){
            Exit();
            return nextState;
        }

        return this;
    }

}

public class Play : GameState{
    public Play() : base(){
        name = STATE.PLAY;
        stage = EVENT.ENTER;
    }

    protected override void Enter()
    {
        base.Enter();
    }

    protected override void Update()
    {
        gameManager.entityAction();
    }

    protected override void Exit()
    {
        base.Exit();
    }
}