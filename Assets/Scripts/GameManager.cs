using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance = null;

    private void Awake(){
        if(_instance==null){
            _instance = this;
        }
    }

    public static GameManager instance(){
        return _instance;
    }

    private GameState state;
    public Player player;

    void Start()
    {
        state = new Play();
    }

    void Update()
    {
        state = state.process;
    }

    public void entityAction(){
        //player, enemy, spawner stuff
        player.move();
    }
}
