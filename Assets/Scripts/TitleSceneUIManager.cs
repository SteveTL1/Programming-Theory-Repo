using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class TitleSceneUIManager : MonoBehaviour
{
    // ABSTRACTION
    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }
    // ABSTRACTION
    public void EndApplication()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

}
