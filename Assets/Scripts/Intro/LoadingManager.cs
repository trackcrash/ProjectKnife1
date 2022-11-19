using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingManager : MonoBehaviour
{
    //singleton
    private LoadingManager Instance;
    public static LoadingManager instance = null;
    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this){
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    

}
