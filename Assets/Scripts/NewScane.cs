using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class NewScane : MonoBehaviour
{
    protected void NewGameStart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}