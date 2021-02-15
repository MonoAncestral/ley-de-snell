using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Rotate : MonoBehaviour
{
    int velocidade = 30;
    public GameObject Laser2;
    public TMP_InputField tmpInputField;
    public Rigidbody rb;
    public TMP_Text tmpText;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void rotar()
    {
        Vector3 EulerAngles1 = transform.eulerAngles;

        if (tmpInputField.text != "" && float.TryParse(tmpInputField.text, out _) && float.Parse(tmpInputField.text) > 0 && float.Parse(tmpInputField.text) < 90)
        {
            rb.isKinematic = false;
            EulerAngles1.y = float.Parse(tmpInputField.text);
            transform.eulerAngles = EulerAngles1;
            Vector3 Position = transform.position;

            Position.x = -8.093337F;
            Position.y = 3.736666F;
            Position.z = -0.8500035F;

            //transform.position = Position;

            transform2(EulerAngles1);
            rb.isKinematic = true;
        }
    }
    private void transform2(Vector3 vector)
    {
        Vector3 EulerAngles2 = Laser2.transform.eulerAngles;
        EulerAngles2.y = (vector.y) / 1.5F;
        Laser2.transform.eulerAngles = EulerAngles2;
        tmpText.text = EulerAngles2.y + "°";
        //Laser2.transform.position = position;
    }
}
