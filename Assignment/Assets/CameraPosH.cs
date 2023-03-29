using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CameraPosH : MonoBehaviour
{
    public GameObject CityPosCube;
    private float altitude;
    public TextMeshProUGUI altitudeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        altitude = transform.position.y - CityPosCube.transform.position.y;
        altitudeText.text = "Altitude : "+ Mathf.Round(altitude).ToString();
    }
}
