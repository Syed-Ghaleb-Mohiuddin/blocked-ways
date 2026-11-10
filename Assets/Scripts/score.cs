using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    private Transform Player;
    public Text scoretext;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<Transform>();

    }
    void Update()
    {
        scoretext.text = Player.position.z.ToString("0");
    }
}
