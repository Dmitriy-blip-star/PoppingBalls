using UnityEngine;

public abstract class Winners: MonoBehaviour
{
    public virtual bool CheckWin(string ballTag)
    {
        return true;
    }
    public virtual bool CheckWin()
    {
        return true;
    }
}


