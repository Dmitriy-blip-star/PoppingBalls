using UnityEngine;

namespace Assets
{
    public class WinChecker : MonoBehaviour
    {
        SameColor sameColor = new SameColor();
        AllColor allColor = new AllColor();

        public bool whiteBall = false;
        public bool yellowBall = false;
        public bool greenBall = false;
        public bool allBall = false;

        private void Update()
        {
            if (whiteBall)
            {
                sameColor.CheckWin("WhiteBall");
            }
            else if (yellowBall)
            {
                sameColor.CheckWin("YellowBall");
            }
            else if (greenBall)
            {
                sameColor.CheckWin("GreenBall");
            }
            else if (allBall)
            {
                allColor.CheckWin();
            }
        }
    }
}