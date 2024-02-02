using System;
using UnityEngine;

[Serializable]
enum PlanetType
{
    TELLURIC,
    GAS_GIANT,
    OTHER
}

[CreateAssetMenu(fileName = "Planet", menuName = "New Planet")]
public class Planet : ObjectToScan
{
    #region Variables
    [SerializeField] PlanetType type;
    [SerializeField] float radius = 0f;
    [SerializeField] float circumference = 0f;
    [SerializeField] float distanceFromSun = 0f;
    [SerializeField] float dayLength = 0f;
    [SerializeField] float orbitalPeriod = 0f;
    [SerializeField] float gravity = 0f;
    #endregion Variables
}