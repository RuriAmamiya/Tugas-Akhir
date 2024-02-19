using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof (Slider))]
public class FPController : MonoBehaviour
{
    public Transform mainCamera;
    public LayerMask layerMask;
    float angle = 0;
    Rigidbody playerRigidbody;
    RaycastHit hit;

    private float mouseSens = 100;
    public Slider slider;
    public Text sensValue;
    public Animator animator;
    private CharacterController charcc;
    private Vector2 Move;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        playerRigidbody = GetComponent<Rigidbody>();

        slider.GetComponent<Slider>();
        UpdateValueOnChange(slider.value);

        slider.onValueChanged.AddListener(delegate
        {
            UpdateValueOnChange(slider.value);
        });
    }

    // Update is called once per frame
    void Update()
    {
        //rotate kiri kanan
        /*transform.Rotate(Vector3.up,Input.GetAxis("Mouse X") * 5);

        //rotate atas bawah
        angle=Mathf.Clamp(Input.GetAxis("Mouse Y") * -5 + angle, -60, 60);
        mainCamera.localRotation=Quaternion.Euler(new Vector3(angle,0,0)); */

        float mouseX = Input.GetAxis("Mouse X") * mouseSens;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens;

        angle = Mathf.Clamp(mouseY * -5 + angle, -60, 60);

        mainCamera.localRotation=Quaternion.Euler(new Vector3(angle,0,0));
        transform.Rotate(Vector3.up,mouseX * 5);

        //movement
        Vector3 velocity = transform.rotation * new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical")).normalized * 5;
        velocity.y = Input.GetKeyDown(KeyCode.Space) & Physics.SphereCast(transform.position,.50f,Vector3.down,out hit,.3f,layerMask) ? 5 : playerRigidbody.velocity.y;
        playerRigidbody.velocity = velocity;
    }

    public void sensitivity(float sens)
    {
        mouseSens = sens;
    }

    private void UpdateValueOnChange(float value)
    {
        if(sensValue != null)
        {
            sensValue.text = Mathf.Round(value * 100.0f).ToString() + "%";
        }
    }

    private void Animating () {
        if(animator == null) return;
        float magnitude = charcc.velocity.magnitude/charcc.velocity.magnitude;
        animator.SetFloat("walkX", Move.x * magnitude);
        animator.SetFloat("walkZ", Move.y * magnitude);
    }
}
