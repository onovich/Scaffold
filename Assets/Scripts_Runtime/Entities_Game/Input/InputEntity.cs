using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Scaffold {

    public class InputEntity {

        public Vector2 moveAxis;
        InputKeybindingComponent keybindingCom;

        public void Ctor() {
            keybindingCom.Ctor();
        }

        public void ProcessInput(Camera camera, float dt) {

            if (keybindingCom.IsKeyPressing(InputKeyEnum.MoveLeft)) {
                moveAxis.x = -1;
            } else if (keybindingCom.IsKeyPressing(InputKeyEnum.MoveRight)) {
                moveAxis.x = 1;
            } else if (keybindingCom.IsKeyPressing(InputKeyEnum.MoveUp)) {
                moveAxis.y = 1;
            } else if (keybindingCom.IsKeyPressing(InputKeyEnum.MoveDown)) {
                moveAxis.y = -1;
            } else {
                moveAxis = Vector2.zero;
            }

        }

        public void Keybinding_Set(InputKeyEnum key, KeyCode[] keyCodes) {
            keybindingCom.Bind(key, keyCodes);
        }

        public void Reset() {
            moveAxis = Vector2.zero;
        }

    }

}