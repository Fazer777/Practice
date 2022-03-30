using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    float xRot;
    float yRot;
    float speedRot = 3f; // speed rotate camera

    float xCurRot;
    float yCurRot;
    float xCurV;
    float yCurV;

    float CamMax = 100f; // 
    float CamMin = 0f;

    float TransX;
    float TransZ;

    void Update()
    {
        CameraRotation();
        CameraZoom();
        CameraTranslate();
    }
    void CameraRotation()
    {
        if (Input.GetMouseButton(1))
        {
            xRot -= Input.GetAxis("Mouse Y") * speedRot;
            yRot += Input.GetAxis("Mouse X") * speedRot;

            xRot = Mathf.Clamp(xRot, -85, 85);

            xCurRot = Mathf.SmoothDamp(xCurRot, xRot, ref xCurV, 0.1f);
            yCurRot = Mathf.SmoothDamp(yCurRot, yRot, ref yCurV, 0.1f);

            gameObject.transform.rotation = Quaternion.Euler(xCurRot, yCurRot, 0);
        }
    }
    void CameraZoom()
    {
        if ((Input.GetAxis("Mouse ScrollWheel") < 0) && (gameObject.transform.position.y < CamMax))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 0.1f, gameObject.transform.position.z);
        }
        if ((Input.GetAxis("Mouse ScrollWheel") > 0) && (gameObject.transform.position.y > CamMin))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 0.1f, gameObject.transform.position.z);
        }
    }
    void CameraTranslate()
    {
        TransX = Input.GetAxis("Vertical") * 3.5f * Time.deltaTime;
        TransZ = Input.GetAxis("Horizontal") * 3.5f * Time.deltaTime;

        gameObject.transform.Translate(TransZ, 0, TransX);
    }
}

