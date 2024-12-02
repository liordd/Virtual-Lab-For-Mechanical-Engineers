using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    [SerializeField] private Camera fpsCamera;
    private Ray ray;
    private RaycastHit hit;
    [SerializeField] private float maxDistRay;


        public GameObject Osc;
        public GameObject Tisk;
        public GameObject Yashik;
        public GameObject RuPod;
        public GameObject Car;
        public GameObject Pod;
        public GameObject Gaz;
        public GameObject Verst;
        public GameObject Anal;
        public GameObject Ins;


    public GameObject[] boba;




    private void Update()
    {
        Ray();
        DrawRay();
        Interact();
    }

    private void Ray()
    {
        ray = fpsCamera.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));

    }

    private void DrawRay()
    {
        if (Physics.Raycast(ray, out hit, maxDistRay));
        {
            Debug.DrawRay(ray.origin, ray.direction * maxDistRay, Color.blue);
        }

        if (hit.transform == null)
        {
            Debug.DrawRay(ray.origin, ray.direction * maxDistRay, Color.red);
        }
    }



    private void Interact()
    {
        if (hit.transform != null && hit.transform.GetComponent<Rigidbody>())
        {
            Debug.DrawRay(ray.origin, ray.direction * maxDistRay, Color.green);

                if (hit.transform.tag == "Osc" && (boba[0]).tag == ("Osc"))
                {
                    
                    Osc.SetActive(true);
                }


                else if (hit.transform.tag == "Tisk" && (boba[1]).tag == ("Tisk"))
                {
                    
                    Tisk.SetActive(true);
                }

                else if (hit.transform.tag == "Yashik" && (boba[2]).tag == ("Yashik"))
                {

                    Yashik.SetActive(true);
                }
                else if (hit.transform.tag == "RuPod" && (boba[3]).tag == ("RuPod"))
                {

                    RuPod.SetActive(true);
                }
                else if (hit.transform.tag == "Car" && (boba[4]).tag == ("Car"))
                {

                    Car.SetActive(true);
                }
                else if (hit.transform.tag == "Pod" && (boba[5]).tag == ("Pod"))
                {

                    Pod.SetActive(true);
                }
                else if (hit.transform.tag == "Gaz" && (boba[6]).tag == ("Gaz"))
                {

                    Gaz.SetActive(true);
                }
                else if (hit.transform.tag == "Verst" && (boba[7]).tag == ("Verst"))
                {

                    Verst.SetActive(true);
                }
                else if (hit.transform.tag == "Anal" && (boba[8]).tag == ("Anal"))
                {

                    Anal.SetActive(true);
                }
                else if (hit.transform.tag == "Ins" && (boba[9]).tag == ("Ins"))
                {

                    Ins.SetActive(true);
                }





        }
           
           
        

        else
        {
            Osc.SetActive(false);
            Tisk.SetActive(false);
            Yashik.SetActive(false);
            RuPod.SetActive(false);
            Car.SetActive(false);
            Pod.SetActive(false);
            Gaz.SetActive(false);
            Verst.SetActive(false);
            Anal.SetActive(false);
            Ins.SetActive(false);
        }
    }
}
