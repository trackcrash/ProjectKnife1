using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private GameManager Instance;
    public static GameManager instance = null;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

    }
    
    //Sliders
    public Slider hpSlider;
    public Slider staminaSlider;
    //player
    public PlayerController player;

    void Update()
    {
        hpSlider.value = player.Hp;
        staminaSlider.value = player.Stamina;
    }

}
