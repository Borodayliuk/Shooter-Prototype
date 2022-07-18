using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayShooter : MonoBehaviour
{
    [SerializeField] SpriteRenderer _hole;
    private Camera _camera;
    void Start()
    {
        _camera = GetComponent<Camera>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void OnGUI()
    {
        int size = 100;
        float posX = _camera.pixelWidth / 2 - size / 4;
        float posY = _camera.pixelHeight / 2 - size / 2;
        GUI.skin.label.fontSize = 100;
        GUI.Label(new Rect(posX, posY, size, size), "+");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 point = new Vector3(_camera.pixelWidth/2, _camera.pixelHeight/2, 0);
            Ray ray = _camera.ScreenPointToRay(point);
            
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                GameObject hitObject = hit.transform.gameObject;
                ReactiveTarget target = hitObject.GetComponent<ReactiveTarget>();
                if (target != null)
                {
                    target.ReactToHit();
                }
                else
                {
                    StartCoroutine(_SphereIndicator(hit));
                }
            }
        }
    }

    private IEnumerator _SphereIndicator(RaycastHit pos)
    {
        SpriteRenderer s = Instantiate(_hole.gameObject, pos.point, Quaternion.LookRotation(pos.normal)).GetComponent<SpriteRenderer>();
        s.transform.position-=transform.forward*0.1f;

        yield return new WaitForSeconds(2);

        Destroy(s);
    }
}
