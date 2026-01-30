using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Start(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void Create(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
