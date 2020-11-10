using UnityEngine;
using Game.Scripts;

public class FixStylesErrors : MonoBehaviour
{

    private Collider _myCustomCollider;

    private DataClass _customData;

    private SampleScript _sampleScript;

    private readonly string _customName = "fixStylesErrors";

    private void Awake()
    {
        _customData = new DataClass
        {
            sample = 2
        };
        _myCustomCollider = GetComponent<Collider>();

        _sampleScript = GetComponent<SampleScript>();
    }

    public string SampleParamsFunction(string value)
    {
        return $"Hello, {value}";
    }
     
    private void simpleFunction()
    {

    }

}
