using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terraintoggles : MonoBehaviour
{
    public Material Ocean;
    public Material Desert;
    public Material Purple;
    public Material Grass;
    public Material OceanBox;
    public Material DesertBox;
    public Material PurpleBox;
    public Material GrassBox;
    private Material[] maps;
    private Material[] mats;
    private int i;
    public GameObject passer;


    // Start is called before the first frame update
    void Start()
    {
        maps = new Material[5];
        mats = new Material[5];
        i = 1;
        maps[1] = Ocean;
        maps[2] = Desert;
        maps[3] = Purple;
        maps[4] = Grass;
        mats[1] = OceanBox;
        mats[2] = DesertBox;
        mats[3] = PurpleBox;
        mats[4] = GrassBox;
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown("space"))
        { 
            if ( i == 4){ 
                i = 1;
            }else{
                i++;
            }
            RenderSettings.skybox = mats[i];
            DynamicGI.UpdateEnvironment();
            passer.GetComponent<MeshRenderer>().material = maps[i];
        }
    }
}
