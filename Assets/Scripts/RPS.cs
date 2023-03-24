using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPS : MonoBehaviour
{
    public int rpsSign; // 0,1,2 is rock, paper, scissors

    int rpsGamestate = 0;   // 1 is win, 0 is tie, -1 is lose

    private void OnMouseDown() {
        int enemyInput = Random.Range(0, 2);
        
        if(rpsSign == enemyInput){
            // tie
            rpsGamestate = 0;
        }
        else if(
            (rpsSign == enemyInput + 1)
            || (rpsSign == 2 && enemyInput == 0)
            ){
            
            // player looses
            rpsGamestate = -1;
        }
        else{
            // player wins
            rpsGamestate = 1;
        }
    }
}
