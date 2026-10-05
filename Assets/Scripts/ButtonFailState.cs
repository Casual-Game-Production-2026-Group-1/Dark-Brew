using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;


public class FailStateManager : MonoBehaviour
{

    public void TriggerFailState()
    {
        Debug.Log("Fail state triggered!");

        Time.timeScale = 0f;

        print("Failure!");

        Thread.Sleep(3000);

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);

    }
}