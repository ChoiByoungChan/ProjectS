using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Crop")]
public class Crop : Item
{
    [SerializeField]
    private float _growTime;
    public float growTime { get { return _growTime; } private set {} }
    [SerializeField]
    private float _discardTime;
    public float discardTime { get { return _discardTime; } private set {} }
    [SerializeField]
    private float _fruitCount;
    public float fruitCount { get { return _fruitCount; } private set { } }
}