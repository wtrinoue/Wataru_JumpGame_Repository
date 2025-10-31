using UnityEngine;
using UnityEngine.SceneManagement; // ← これでSceneManagerを使えるようになる

public class ChangeScene : MonoBehaviour
{
    public void GoToNextScene()
    {
        SceneManager.LoadScene("TitleScene"); // Unity標準ライブラリのSceneManager
    }
}
