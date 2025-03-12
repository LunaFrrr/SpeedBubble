using UnityEngine;

public class MaintainPos : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Vector3 posBase;
    Vector3 offSet;
    Vector3 newPos;
    public GameObject parent;
    void Start()
    {
        posBase = new Vector3(-3000,-1000,0);

    }

    // Update is called once per frame
    void Update()
    {
        offSet = parent.transform.position - posBase;
        
        transform.localPosition = new Vector3(3000 , 1000, 0) - offSet;
    }
}
