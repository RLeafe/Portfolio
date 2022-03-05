using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Projects : MonoBehaviour
{
    public Button nextButton;
    public Button prevButton;

    public TMP_Text title;
    public TMP_Text description;
    public Image image;

    [SerializeField] public List<Pages> pageList;

    private int curPage = 0;

    //Start on the 'Home' page
    public void Start()
    {
        title.SetText(pageList[curPage].title);
        description.SetText(pageList[curPage].description);
        image.sprite = pageList[curPage].image;

        //Prev Button not active by default
        prevButton.gameObject.SetActive(false);
    }

    public void OnSelectNext()
    {
        if (curPage == pageList.Count - 1) { nextButton.gameObject.SetActive(false); }
        else { nextButton.gameObject.SetActive(true); }

        if(curPage >= 1) prevButton.gameObject.SetActive(true);

        //Update the page details
        title.SetText(pageList[curPage].title);
        description.SetText(pageList[curPage].description);
        image.sprite = pageList[curPage].image;
    }

    public void OnSelectPrev()
    {
        if (curPage >= 0) nextButton.gameObject.SetActive(true);

        //Update the page details
        title.SetText(pageList[curPage].title);
        description.SetText(pageList[curPage].description);
        image.sprite = pageList[curPage].image;
    }

    public void PrevPage(int num)
    {
        curPage -= num;
        if(curPage <= 0) prevButton.gameObject.SetActive(false);
    }

    public void NextPage(int num)
    {
        curPage += num;
    }
}
