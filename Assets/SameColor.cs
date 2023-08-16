using UnityEngine;

public class SameColor: Winners
{
    GameObject[] balls;

    public override bool CheckWin(string ballTag)
    {
        balls = GameObject.FindGameObjectsWithTag(ballTag);
        if (balls.Length != 0)
        {
            return false;
        }
        Debug.Log("You win!");
        return true;
    }
}


