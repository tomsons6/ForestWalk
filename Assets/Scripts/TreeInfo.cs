using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
public class TreeInfo : MonoBehaviour
{
    public SteamVR_Action_Boolean Trigger;
    private SteamVR_Behaviour_Pose m_Pose;
    // Start is called before the first frame update
    void Start()
    {
        m_Pose = GetComponent<SteamVR_Behaviour_Pose>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Trigger.GetStateDown(m_Pose.inputSource))
        {
            ShowTreeInfo();
        }
    }
    void ShowTreeInfo()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 50f))
        {
            Debug.Log(hit.transform.ToString());
        }

    }
}
