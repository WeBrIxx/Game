using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MENUManager : MonoBehaviour
{
    public void START()
    {
        SceneManager.LoadScene(1);
    }
    public void EXIT()
    {
        Application.Quit();
    }
}
