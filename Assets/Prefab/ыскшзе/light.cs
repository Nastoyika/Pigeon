using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Valve.VR.InteractionSystem;
public class light : MonoBehaviour
{
    private Hand.AttachmentFlags attachmentFlags = Hand.defaultAttachmentFlags & (~Hand.AttachmentFlags.SnapOnAttach) & (~Hand.AttachmentFlags.DetachOthers) & (~Hand.AttachmentFlags.VelocityMovement);
    private Interactable interactable;
    static private int unityid = -1;
    public bool on=false;
    void Start()
    {
        interactable = this.GetComponent<Interactable>();
    }
    private void Debug()
    {
        if (gameObject.GetInstanceID() != unityid)
        {
            UnityEngine.Debug.Log("Hover on:" + gameObject.name);
            unityid = gameObject.GetInstanceID();
        }
    }
    private void HandHoverUpdate(Hand hand)
    {

        Debug();

        if (hand.GetGrabStarting() != GrabTypes.None)
        {
            if (transform.GetComponent<Anim_script>() != null)
            {
                on = !on;
            transform.GetComponent<Anim_script>().CliclEvent(transform);
                
            }


        }
        //else if (hand.IsGrabEnding(this.gameObject))
        //{
        //    UnityEngine.Debug.Log("Grab off");
        //    hand.HoverUnlock(interactable);
        //    hand.DetachObject(gameObject);
        //}
    }
}
