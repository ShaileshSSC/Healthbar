using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Butt : MonoBehaviour
{
    private int health = 10;
    private int damage = 1;
    public Button yourButton;
    public Slider mainSlider;
    public Text score;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        score.text = "health: " + health;
    }

    void TaskOnClick()
    {
        if (health > 0)
        {
            health = health - damage;
            Debug.Log(health);
        }

        mainSlider.value = health;
        score.text = "health: " + health;
        if (health == 0)
        {
            score.text = "YOU DIED";
            score.color = Color.red;
        }
    }
}