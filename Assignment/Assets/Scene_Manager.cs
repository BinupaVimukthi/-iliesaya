using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Loc1()
    {
        SceneManager.LoadScene("Location_01");
    }
    public void Loc2()
    {
        SceneManager.LoadScene("Location_02");
    }
    public void Loc3()
    {
        SceneManager.LoadScene("Location_03");
    }
}
