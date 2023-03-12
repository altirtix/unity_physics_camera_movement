using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public GameObject target;

    public Vector3 offsetPosition = new Vector3(0f, 4f, -4f);

    public Space offsetPositionSpace = Space.World;

    public bool lookAt = true;

    private void LateUpdate()
    {
        Refresh();
    }

    public void Refresh()
    {
        // compute position
        if (offsetPositionSpace == Space.Self)
        {
            transform.position = target.transform.TransformPoint(offsetPosition);
        }
        else
        {
            transform.position = target.transform.position + offsetPosition;
        }

        // compute rotation
        //if (lookAt)
        //{
            //transform.LookAt(target);
        //}
        //else
        //{
            //transform.rotation = target.rotation;
        //}
    }
}