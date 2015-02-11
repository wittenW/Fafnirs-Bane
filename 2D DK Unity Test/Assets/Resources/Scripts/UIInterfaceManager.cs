using UnityEngine;
using System.Collections;

public class UIInterfaceManager : MonoBehaviour
{
    private static UIInterfaceManager _instance;

    /// <summary>
    /// Creates an instance of UIInterfaceManager as a gameobject if an instance does not exist
    /// </summary>
    public static UIInterfaceManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = new GameObject("UIInterfaceManager").AddComponent<UIInterfaceManager>();
            
            return _instance;
        }
    }

    private static GameObject _controlsOverlay;
    public static GameObject Overlay
    {
        get
        {
            if (_controlsOverlay == null)
                _controlsOverlay = (GameObject)Instantiate(Resources.Load("UI/Interface"));
            return _controlsOverlay;
        }
    }


    void Start()
    {
        DontDestroyOnLoad(Overlay);
    }

}
