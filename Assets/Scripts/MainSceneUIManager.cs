using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class MainSceneUIManager : MonoBehaviour
{
    public static MainSceneUIManager Instance { get; private set; }   
    public TextMeshProUGUI dogRaceText;
    public TextMeshProUGUI dogNameText;
    protected string dogNameReturn;
    protected string dogRaceReturn;

    private void Awake()
    {
        Instance = this;
    }
    // ABSTRACTION
    public void OnAwakeChangeUI()
    {
        dogRaceText.text = "You´re Dog´s race is: " + dogRaceReturn;
        dogNameText.text = "You´re Dog´s name is: " + dogNameReturn;
    }
    // ABSTRACTION
    public string ChangeName(string dogName)
    {
        dogNameReturn = dogName;
        return dogNameReturn;
    }
    // ABSTRACTION
    public string ChangeRace(string dogRace)
    {
        dogRaceReturn = dogRace;
        return dogRaceReturn;
    }
    // ABSTRACTION
    public void NewDog()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
