using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    

    public void QuitGame()
    {
        // This works if menu scene is first in the build order
        SceneManager.LoadScene(0);
    }
}
