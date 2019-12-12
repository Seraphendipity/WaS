using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstructorController : MonoBehaviour
{

    public GameObject[] pfBuildings;
    public Material protoMat; // Prototype Material
    public float protoDisplacement = 2f; // how much it hovers when prototyping

    private Material realMat; // Real Material
    private bool bBuildingMode = false;
    private int previousBuildingId = 0;
    private GameObject currentBuilding = null;

    public GameObject castlePrefab;

    // Start is called before the first frame update
    void Start()
    {
        // Reece was here :D
        // Change one more line
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab)) {
            bBuildingMode = !bBuildingMode;
        }
        BuildingMode();
    }

    void BuildingMode() {
        //Building Prototpe
        if(bBuildingMode) {

            if(currentBuilding == null) {
                currentBuilding = CreateBuilding(previousBuildingId);
                Vector3 p = currentBuilding.transform.position;
                p.y += protoDisplacement;
                currentBuilding.transform.position = p;
                realMat =  currentBuilding.transform.Find("Model").
                    GetComponent<Renderer>().material;
                currentBuilding.transform.Find("Model").
                    GetComponent<Renderer>().material = protoMat;
            } else {
                RaycastHit hit;
                var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit))
                {
                    Vector3 mouseLoc = hit.point;
                    Quaternion rotation = Quaternion.identity;
                    currentBuilding.transform.position = 
                        new Vector3(mouseLoc.x, protoDisplacement, mouseLoc.z);

                    Debug.Log("Spawning Building");
                    Vector3 spawnPosition = currentBuilding.transform.position;
                    GameObject.Instantiate(this.castlePrefab, spawnPosition, rotation);
                }

                if(Input.GetAxisRaw("MouseScrollWheel") != 0) {
                    if(Input.GetAxisRaw("MouseScrollWheel") == -1f) {
                        // Next Building
                    } else {
                        // Prev Building
                    }
                }

                //Rotate Building

                if(Input.GetMouseButtonDown(2)) {
                    //Place Building
                    if(IsValidBuildingLocation(currentBuilding)) {
                        currentBuilding.transform.position -= new Vector3(0,protoDisplacement,0);
                        //DeProtofy
                        GetComponent<Renderer>().material = realMat;
                        currentBuilding = null;
                        bBuildingMode = false;

                    } else {
                        // Cannot place that there, sire.
                    }
                }
            } 
        } else {
            if(currentBuilding != null) {
                Destroy(currentBuilding);
                currentBuilding = null;
            }
        }

            

    }

    GameObject CreateBuilding(int buildingId) {
        RaycastHit hit;
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            Vector3 placeLocation = hit.point;
            Quaternion rotation = Quaternion.identity;
            return Instantiate(pfBuildings[buildingId], placeLocation, rotation);
        } else {
            // Ground cannot be raytraced.
            return null;
        }
        
    }

    private bool IsValidBuildingLocation(GameObject building) {
        return true;
    }


}
