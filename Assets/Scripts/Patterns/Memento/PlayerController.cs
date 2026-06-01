using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerHistory _history = new PlayerHistory();

    public PlayerMemento Save()
    {
        return new PlayerMemento(transform.position);
    }

    public void Restore(PlayerMemento memento)
    {
        if (memento == null) return;
        transform.position = memento.Position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) transform.position += Vector3.forward;
        if (Input.GetKeyDown(KeyCode.S)) transform.position += Vector3.back;
        if (Input.GetKeyDown(KeyCode.A)) transform.position += Vector3.left;
        if (Input.GetKeyDown(KeyCode.D)) transform.position += Vector3.right;

        if (Input.GetKeyDown(KeyCode.F)) _history.Save(Save());
        if (Input.GetKeyDown(KeyCode.Z)) Restore(_history.Undo());
    }
}