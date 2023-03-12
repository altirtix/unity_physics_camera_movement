using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public Toggle positionToggle;
    public Toggle rotationToggle;
    public Toggle scaleToggle;

    public Button upButton;
    public Button downButton;
    public Button leftButton;
    public Button rightButton;

    public Vector3 positionVector;
    public Vector3 scaleVector;
    public Vector3 rotationVector;
    public Quaternion rotationQuaternion;

    // Start is called before the first frame update
    void Start()
    {
        positionVector = transform.position;
        scaleVector = transform.localScale;
        rotationVector = new Vector3(0, 0, 0);
        rotationQuaternion = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (positionToggle.isOn == true)
        {
            if (upButton.GetComponent<LongPressEventTrigger>().isPointerDown == true)
            {
                positionVector.y++;
            }
            if (downButton.GetComponent<LongPressEventTrigger>().isPointerDown == true)
            {
                positionVector.y--;
            }
            if (leftButton.GetComponent<LongPressEventTrigger>().isPointerDown == true)
            {
                positionVector.x--;
            }
            if (rightButton.GetComponent<LongPressEventTrigger>().isPointerDown == true)
            {
                positionVector.x++;
            }
            transform.position = positionVector;
        }
        else if (rotationToggle.isOn == true)
        {
            if (upButton.GetComponent<LongPressEventTrigger>().isPointerDown == true)
            {
                rotationVector.y++;
            }
            if (downButton.GetComponent<LongPressEventTrigger>().isPointerDown == true)
            {
                rotationVector.y--;
            }
            if (leftButton.GetComponent<LongPressEventTrigger>().isPointerDown == true)
            {
                rotationVector.x--;
            }
            if (rightButton.GetComponent<LongPressEventTrigger>().isPointerDown == true)
            {
                rotationVector.x++;
            }
            rotationQuaternion.eulerAngles = rotationVector;
            transform.localRotation = rotationQuaternion;
        }
        else if (scaleToggle.isOn == true)
        {
            if (upButton.GetComponent<LongPressEventTrigger>().isPointerDown == true)
            {
                scaleVector.y++;
            }
            if (downButton.GetComponent<LongPressEventTrigger>().isPointerDown == true)
            {
                scaleVector.y--;
            }
            if (leftButton.GetComponent<LongPressEventTrigger>().isPointerDown == true)
            {
                scaleVector.x--;
            }
            if (rightButton.GetComponent<LongPressEventTrigger>().isPointerDown == true)
            {
                scaleVector.x++;
            }
            transform.localScale = scaleVector;
        }
    }
}
