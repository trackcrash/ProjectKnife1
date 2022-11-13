using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "ScriptableObjects/EnemyData", order = 1)]
public class EnemyData : ScriptableObject
{
    [SerializeField]
    private float speed;
    public float Speed
    {
        get { return speed; }
    }
    [SerializeField]
    private float gravity;
    public float Gravity
    {
        get { return gravity; }
    }

}
