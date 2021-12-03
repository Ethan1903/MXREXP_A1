using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class AR_Script : MonoBehaviour
{
    [SerializeField] ARTrackedImageManager imgMgr;
    [SerializeField] List<MenuItem> menuItems;

    private void Start()
    {
        print("Img name: " + imgMgr.referenceLibrary[0].name);
    }

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
<<<<<<< Updated upstream
                Img.gameObject.GetComponent<MenuItemDisplay>().Init(menuItem);
            else
            {
                Debug.Log("Can't find menu item1");
                bool ifFound = false;
                foreach (MenuItem menuItem1 in menuItems)
                {
                    if (menuItem1.name == Img.referenceImage.name)
                    {
                        Debug.Log("Found!");
                        menuItem = menuItem1;
                        ifFound = true;
                    }
                }

                if (!ifFound)
                    Debug.Log("Can't find");
=======
            {
                //DataStorage.dataStorageInstance.addedMenu = Img.gameObject.GetComponent<MenuItemDisplay>().addedMenu;
                //DataStorage.dataStorageInstance.displayInfo = Img.gameObject.GetComponent<DataDisplay>();
                //DataStorage.dataStorageInstance.AddItemToData(menuItem);
                Img.gameObject.GetComponent<MenuItemDisplay>().Init(menuItem);
                
                //Img.gameObject.GetComponentInChildren<Button>().onClick.AddListener(DataStorage.dataStorageInstance.UpdateIntakeDisplay);
            }

            Img.destroyOnRemoval = true;
>>>>>>> Stashed changes

            }

            Debug.Log("Image name: " + Img.referenceImage.name);
        }
    }
}
