using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotePlacement : MonoBehaviour
{
    [SerializeField] private GameObject childNote;
    [SerializeField] private GameObject slot;
    public static int notesCorrect;
    // Start is called before the first frame update
    void Start()
    {
        childNote = slot.transform.GetChild(0).gameObject;
        notesCorrect = 0;
    }

    public void OnCollisionEnter2D(Collision2D col) {
        Debug.Log("Collision detected!");
        if (col.gameObject.name == childNote.name) {
            childNote.transform.position = new Vector3(slot.transform.position.x, slot.transform.position.y, slot.transform.position.z);
            childNote.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
            notesCorrect++;
        }
    }
}
