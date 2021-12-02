using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;

public class AR_Script : MonoBehaviour
{
    [SerializeField] ARTrackedImageManager imgMgr;
    [SerializeField] List<MenuItem> menuItems;

    private void OnEnable()
    {
        imgMgr.trackedImagesChanged += OnImageChanged;
    }

    private void OnDisable()
    {
        imgMgr.trackedImagesChanged -= OnImageChanged;
    }

    public void OnImageChanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach (var Img in args.added)
        {
            MenuItem menuItem = menuItems.Find(x => x.menuItemName == Img.referenceImage.name);

            if (menuItem != null)
            {
                DataStorage.dataStorageInstance.addedMenu = Img.transform.Find("Image1").gameObject;
                Img.gameObject.GetComponent<MenuItemDisplay>().Init(menuItem);
                Img.gameObject.GetComponentInChildren<Button>().onClick.AddListener(DataStorage.dataStorageInstance.UpdateIntakeDisplay);
            }

            Img.destroyOnRemoval = true;


            Debug.Log("Image name: " + Img.referenceImage.name);
        }

        foreach (var Img in args.updated)
        {
            Img.gameObject.SetActive(Img.trackingState == UnityEngine.XR.ARSubsystems.TrackingState.Tracking);
        }
    }
}
