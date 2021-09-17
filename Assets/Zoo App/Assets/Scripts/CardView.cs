using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
    public Text title;
    public Text description;
    public Text exhibit;
    public Image animalImage;

    public CardModel[] card;

    public void SelectCart(int cardIndex)
    {
        title.text = card[cardIndex].title;
        description.text = card[cardIndex].description;
        exhibit.text = card[cardIndex].exhibit;
        animalImage.sprite = card[cardIndex].animalImage;
    }
}
