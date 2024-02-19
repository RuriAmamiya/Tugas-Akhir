using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public float range; 
    public LayerMask interactedMask;

    public Renderer rendererMesh;
    public Transform parent;
    public int selected;
    public int maksPick;
    public float rangePlace;

    MeshFilter meshFilterItem, meshFilter;

    // Start is called before the first frame update
    void Start()
    {
        meshFilter = rendererMesh.GetComponent<MeshFilter>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        bool isPickItem = parent.childCount > 0;
        bool isRaycastPick = Physics.Raycast(transform.position, transform.forward, out hit, rangePlace, ~0, QueryTriggerInteraction.Ignore);
        rendererMesh.gameObject.SetActive(isPickItem && isRaycastPick);

        if(isPickItem) {
            rendererMesh.transform.Rotate(Vector3.up, -Input.mouseScrollDelta.y * 10);
            rendererMesh.transform.position = new Vector3(hit.point.x, hit.point.y + (rendererMesh.bounds.size.y * .5f), hit.point.z);

            if(meshFilterItem != null)
                meshFilter.mesh = meshFilterItem.mesh;

            if(isRaycastPick) {
                if(Input.GetKeyDown(KeyCode.Mouse0)) {
                    Place(hit.point);
                }
            }
        } else {
            if(Physics.Raycast(transform.position, transform.forward, out hit, range, interactedMask)) {
                if(Input.GetKeyDown(KeyCode.Mouse0)) {
                    OnRaycast onRaycast = hit.transform.GetComponent<OnRaycast>();
                    onRaycast.OnInteract();
                }
            }
        }

        for(int i = 0; i <  parent.childCount; i++) {
            if(i == selected) {
                parent.GetChild(i).gameObject.SetActive(true);
            } else {
                parent.GetChild(i).gameObject.SetActive(false);
            }
        }
    }

    public void Pickup (Transform m_item) {
        /*if(parent.childCount >= maksPick) return; */

        meshFilter.mesh = m_item.GetComponent<MeshFilter>().mesh;
        m_item.transform.SetParent(parent);
        m_item.transform.localPosition = Vector3.zero;
        m_item.transform.localRotation = Quaternion.Euler(Vector3.zero);
        m_item.GetComponent<Collider>().enabled = false;
        m_item.GetComponent<Rigidbody>().isKinematic = true;
        m_item.GetComponent<PartOfComputer>().enabled = false;
        Debug.Log("Pickup item : " + m_item.gameObject.name);
    }

    public void Place (Vector3 m_point) {
        Transform itemSelected = parent.GetChild(selected);
        itemSelected.SetParent(null);
        itemSelected.localPosition = new Vector3(m_point.x, m_point.y + (rendererMesh.bounds.size.y * .5f), m_point.z);
        itemSelected.rotation = rendererMesh.transform.rotation;
        itemSelected.GetComponent<Collider>().enabled = true;
        itemSelected.GetComponent<Rigidbody>().isKinematic = false;
        itemSelected.GetComponent<PartOfComputer>().enabled = true;
        itemSelected.GetComponent<Rigidbody>().useGravity = true;
        Debug.Log("Place item : " + itemSelected.gameObject.name);
    }

    void OnDrawGizmos () {
        Gizmos.DrawRay(transform.position, transform.forward * range);
    }
}
