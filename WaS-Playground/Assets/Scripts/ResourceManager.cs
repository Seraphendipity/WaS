using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WaS {
    public static class ResourceManager {
        // CHANGEABLE BY PLAYER
        public static class Scrolling {
            public static float scrollSpeed{ get {return 20f;} } // Time it takes to scroll, "smoothness"
            public static float scrollDistance{ get {return 0.4f;} } // Step per Scroll
            public static float rotateSpeed{ get {return 40f;} } // Time it takes to scroll, "smoothness"
            public static float rotateDistance{ get {return 10f;} } // Step per Scroll
        }

        private static void importSettings() {}
        private static void exportSettings() {}
    }
}
