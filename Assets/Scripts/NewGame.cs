using UnityEngine.SceneManagement;
using UnityEngine;

public class NewGame : MonoBehaviour
{
    public void NewGameStart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
