using UnityEngine;
using UnityEngine.UI;

public class DeleteManager : MonoBehaviour
{
    [SerializeField] private GameObject confirmationDialog;

    void Start()
    {
        if (confirmationDialog != null)
        {
            confirmationDialog.SetActive(false);
        }
    }

    public void ShowDeleteConfirmation()
    {
        if (confirmationDialog != null)
        {
            confirmationDialog.SetActive(true);
        }
    }

    public void ConfirmDelete()
    {
        var menuManager = FindFirstObjectByType<ARTemplateMenuManager>();
        if (menuManager != null)
        {
            menuManager.ClearAllObjects();
        }

        if (confirmationDialog != null)
        {
            confirmationDialog.SetActive(false);
        }
    }

    public void CancelDelete()
    {
        if (confirmationDialog != null)
        {
            confirmationDialog.SetActive(false);
        }
    }
}