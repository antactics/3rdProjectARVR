using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;


public class NewRayInteractor : XRRayInteractor
{
    protected override void OnHoverEntered(HoverEnterEventArgs args)
    {
        Debug.Log("호버링 들어감)");
        base.OnHoverEntered(args);
    }

    protected override void OnHoverExited(HoverExitEventArgs args)
    {
        base.OnHoverExited(args);
        Debug.Log("호버링 나감)");
    }
}
