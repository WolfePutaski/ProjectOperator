using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SC_GetMousePosition))]
public class SC_LookDir : MonoBehaviour
{
    Vector3 aimDir;
    float angle;
    SC_GetMousePosition mousePosition;
    // Start is called before the first frame update
    void Start()
    {
        mousePosition = GetComponent<SC_GetMousePosition>();
    }
    // Update is called once per frame
    void Update()
    {
        aimDir = (mousePosition.GetMousePos() - transform.position).normalized;
        angle = Mathf.Atan2(aimDir.y, aimDir.x) * Mathf.Rad2Deg;

        transform.eulerAngles = new Vector3(0, 0, angle);
    }
}
