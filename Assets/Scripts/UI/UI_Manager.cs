using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    public TMP_Text textMesh;
    private void Awake()
    {

    }
    public void UpdateText()
    {
        textMesh.text = Gamemanager.instance.GetWood().ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        Gamemanager.instance.updateWood.AddListener(UpdateText);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
