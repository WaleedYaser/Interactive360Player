using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMenuBehaviour : MonoBehaviour {

    public Transform lookTarget;
    public GameObject canvas;
    public GameObject points;

    private void Start()
    {
        canvas.SetActive(false);
        points.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0) && !canvas.activeSelf)
        {
            _UpdateMenuTransform();
            canvas.SetActive(true);
            points.SetActive(true);
            StartCoroutine(HideCanvas());
        }
    }

   IEnumerator HideCanvas()
    {
        yield return new WaitForSeconds(5f);
        canvas.SetActive(false);
        points.SetActive(false);
    }

   private void _UpdateMenuTransform()
    {
        transform.position = lookTarget.position + lookTarget.forward * 1.5f;
        transform.LookAt(lookTarget);
        //transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);    
    }
}
