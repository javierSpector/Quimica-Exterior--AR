using System;
using UnityEngine;


public class EventsController : MonoBehaviour {

    public static EventsController current;

    private void Awake() {
        current = this;
    }

    public event Action onSwipeLeft;
    public event Action onSwipeRight;

    public void SwipeLeft() {
        if (onSwipeLeft != null) {
            onSwipeLeft();
        }
    }

    public void SwipeRight() {
        if (onSwipeRight != null) {
            onSwipeRight();
        }
    }
}
