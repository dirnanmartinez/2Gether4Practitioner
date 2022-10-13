using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{

    public event Action OnLoading;
    public event Action OnLogin;
    public event Action OnRegister;
    public event Action onOptionsMenu;
    public event Action OnMainMenu;
    public event Action OnItemsMenu;
    public event Action OnARPosition;
    

    //Patron Singleton
    public static GameManager instance;
    private void Awake()
    {
        if(instance != null && instance!= this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        //MainMenu();
        LoadingMenu(); 
    }

    //IEnumerator LoadingMenu()
    public void LoadingMenu()
    {
        OnLoading?.Invoke();
        //IniciarTimer();
        Debug.Log("Loading 0 menu ACTIVATED");
        StartCoroutine(Loadingg());
        //yield return new WaitForSecondsRealtime(1);
        
    }

    IEnumerator Loadingg()
    {
        yield return new WaitForSecondsRealtime(2);
        LoginMenu();
    }    

    public void LoginMenu()
    {
        OnLogin?.Invoke();
        Debug.Log("Login menu ACTIVATED");
    }

    public void RegisterMenu()
    {
        OnRegister?.Invoke();
        Debug.Log("Register menu ACTIVATED");
    }

    public void OptionsMenu()
    {
        onOptionsMenu?.Invoke();
        Debug.Log("Options menu ACTIVATED");
    }

    public void MainMenu()
    {
        OnMainMenu?.Invoke();
        Debug.Log("Main menu ACTIVATED");
    }

    public void ItemsMenu()
    {
        OnItemsMenu?.Invoke();
        Debug.Log("Item menu ACTIVATED");
    }

    public void ARPosition()
    {
        OnARPosition?.Invoke();
        Debug.Log("AR Position ACTIVATED");
    }

    public void CloseApp()
    {
        Application.Quit();
    }
}
