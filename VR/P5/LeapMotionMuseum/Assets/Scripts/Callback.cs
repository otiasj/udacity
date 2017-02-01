using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Callback {
    void onStartMoving(int destinationIndex);
    void onDestinationReached(int destinationIndex);
}
