﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISelectable
{
    void Select();
    void ListenTo(Player player, PlayerInputManager input);
}