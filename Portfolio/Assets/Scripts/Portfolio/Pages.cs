using UnityEngine;

[CreateAssetMenu(fileName = "New Project", menuName = "Page")]
public class Pages : ScriptableObject
{
    public string title;
    public string description;

    public Sprite image;

    public string repoURL;
    public string exampleURL;
}
