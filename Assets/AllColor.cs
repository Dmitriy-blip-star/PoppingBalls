using UnityEngine;

namespace Assets
{
    public class AllColor : Winners
    {
        PoppedBall[] poppedBalls;
        public override bool CheckWin()
        {
            poppedBalls = GameObject.FindObjectsOfType<PoppedBall>();

            if (poppedBalls.Length != 0)
            {
                return false;
            }
            Debug.Log("You win!");
            return true;
        }
    }
}