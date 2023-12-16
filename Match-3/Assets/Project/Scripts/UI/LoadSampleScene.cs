using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSampleScene : MonoBehaviour
{
    public Button button;

    public void SelectButtom()
    {
        SceneManager.LoadScene(1);
    }
}
