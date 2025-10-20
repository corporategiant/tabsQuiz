using UnityEngine;
using UnityEngine.SceneManagement;

public class EditRoundMarker : MonoBehaviour
{
    public bool PlayEditMarker;
    public bool TestEditSaveMarker;
    public bool TestEditPublishMarker;
    public bool PublishedMarker;

    public GameObject PlayEdit;
    public GameObject TestEditSave;
    public GameObject TestEditPublish;
    public GameObject Published;
    public GameObject Question1;

    public string SceneToLoad;


    public void MarkEditRound_PlayEdit()
    {
        PlayEditMarker = true;
        TestEditSaveMarker = false;
        TestEditPublishMarker = false;
        PublishedMarker = false;
    }

    public void MarkEditRound_TestEditSave()
    {
        PlayEditMarker = false;
        TestEditSaveMarker = true;
        TestEditPublishMarker = false;
        PublishedMarker = false;
    }

    public void MarkEditRound_TestEditPublish()
    {
        PlayEditMarker = false;
        TestEditSaveMarker = false;
        TestEditPublishMarker = true;
        PublishedMarker = false;
    }

    public void MarkEditRound_Published()
    {
        PlayEditMarker = false;
        TestEditSaveMarker = false;
        TestEditPublishMarker = false;
        PublishedMarker = true;
    }

    public void PreviousEditMenu()
    {
        if (PlayEditMarker == true)
        {
            PlayEdit.SetActive(true);
            Question1.SetActive(false);
        }
        else if (TestEditSaveMarker == true)
        {
            TestEditSave.SetActive(true);
            Question1.SetActive(false);
        }
        else if (TestEditPublishMarker == true)
        {
            TestEditPublish.SetActive(true);
            Question1.SetActive(false);
        }
        else if (PublishedMarker == true)
        {
            Published.SetActive(true);
            Question1.SetActive(false);
        }
        else
        {
            SceneManager.LoadScene(SceneToLoad);
        }
    }

}
