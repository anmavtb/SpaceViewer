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

    public void VariablesToTuple()
    {
        var radiusTuple = FormatTuple("Radius", radius, "km");
        var circumferenceTuple = FormatTuple("Circumference", circumference, "km");
        var distanceFromSunTuple = FormatTuple("Distance from Sun", distanceFromSun, "millions of km");
        var dayLengthTuple = FormatTuple("Day length", dayLength, "hours");
        var orbitalPeriodTuple = FormatTuple("Orbital period", orbitalPeriod, "Earth's days");
        var gravityTuple = FormatTuple("Gravity", gravity, "m/s²");
    }

    (string valueType, float value, string unit) FormatTuple(string _valuetype, float _value, string _unit)
    {
        return (_valuetype, _value, _unit);
    }
}