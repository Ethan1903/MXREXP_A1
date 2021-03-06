using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

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
<<<<<<< HEAD
            {
                DataStorage.dataStorageInstance.addedMenu = Img.gameObject.GetComponent<MenuItemDisplay>().addedMenu;
=======
>>>>>>> parent of 4ab5b5f (Added Data Storage)
                Img.gameObject.GetComponent<MenuItemDisplay>().Init(menuItem);

            Img.destroyOnRemoval = true;

            Debug.Log("Image name: " + Img.referenceImage.name);
        }

        foreach (var Img in args.updated)
        {
            Img.gameObject.SetActive(Img.trackingState == UnityEngine.XR.ARSubsystems.TrackingState.Tracking);
        }
    }
}
