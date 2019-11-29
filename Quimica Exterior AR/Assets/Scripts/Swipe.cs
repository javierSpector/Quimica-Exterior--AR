using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour {

    private bool tap, swipeLeft, swipeRight, swipeUp, swipeDown;
    private bool isDraging = false;
    private Vector2 startTouch, swipeDelta;

    public int distancePixels = 125;

    // Update is called once per frame
    void Update() {
        tap = swipeLeft = swipeRight = swipeUp = swipeDown = false;

        #region Keyboard Inputs

        if (Input.GetMouseButtonDown(0)) {
            tap = true;
            isDraging = true;
            startTouch = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0)) {
            isDraging = false;
            Reset();
        }

        #endregion

        #region Mobile Inputs

        if (Input.touches.Length > 0) {
            if (Input.touches[0].phase == TouchPhase.Began) {
                tap = true;
                isDraging = true;
                startTouch = Input.touches[0].position;
            }
            else if (Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled) {
                isDraging = false;
                Reset();
            }
        }

        #endregion


        swipeDelta = Vector2.zero;
        if (isDraging) {
            if (Input.touches.Length > 0)
                swipeDelta = Input.touches[0].position - startTouch;
            else if (Input.GetMouseButton(0)) {
                swipeDelta = (Vector2) Input.mousePosition - startTouch;
            }
        }

        if (swipeDelta.magnitude > distancePixels) {
            float x = swipeDelta.x;
            float y = swipeDelta.y;

            if (Mathf.Abs(x) > Mathf.Abs(y)) {
                if (x < 0) {
//                    swipeLeft = true;
                    EventsController.current.SwipeLeft();
                }

                else {
//                    swipeRight = true;
                    EventsController.current.SwipeRight();
                }
            }
            else {
                if (y < 0)
                    swipeDown = true;
                else
                    swipeUp = true;
            }
            
            Reset();
        }
    }

    private void Reset() {
        startTouch = swipeDelta = Vector2.zero;
        isDraging = false;
    }
    
    

    public bool Tap {
        get => tap;
        set => tap = value;
    }

    public bool SwipeLeft{
        get => swipeLeft;
        set => swipeLeft = value;
    }

    public bool SwipeRight {
        get => swipeRight;
        set => swipeRight = value;
    }

    public bool SwipeUp {
        get => swipeUp;
        set => swipeUp = value;
    }

    public bool SwipeDown {
        get => swipeDown;
        set => swipeDown = value;
    }

    public Vector2 StartTouch {
        get => startTouch;
        set => startTouch = value;
    }

    public Vector2 SwipeDelta {
        get => swipeDelta;
        set => swipeDelta = value;
    }
}
