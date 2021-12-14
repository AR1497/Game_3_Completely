using UnityEngine;

public abstract class InteractiveObject : MonoBehaviour
{
    public delegate void MethodContainer(); 
    public event MethodContainer onPointInGame;

    protected void Interaction()
    {
        onPointInGame?.Invoke();
    }
}

